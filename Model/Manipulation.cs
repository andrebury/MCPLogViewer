using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace MCPLOGViewer.Model
{
    public class Data
    {
        public string[] Palavra;
        //public string Cor;
    }


    public class Manipulation
    {
        //Dictionary<string, string> posicaoCor;
        public int opDestaque;
        List<string> linhas;
        object[] itens;
        List<string> calllegids;
        string pastaConfig = Environment.GetEnvironmentVariable("appdata").ToString() +  "\\MCPLogViewer";
        public List<string> ListaPalavrasImportantes;
        public string opFonte;
        public string opTamanho;
        string[] palavrasProcuradas = { "prompt_start", "Adding userdata", "prompt_stop", "X-Genesys-", "ANI=sip:", "form_enter :", "form_exit ", "goto :#" };
        public Data data;

        public Manipulation()
        {
            ListaPalavrasImportantes = new List<string>();

            //carregaPalavrasImportantes();
            data = new Data();
            XMLDataReader();
        }
        

        public void XMLDataWriter(string[] obj)
        {
            File.Delete(pastaConfig + "\\PalavrasImportantes.xml");

            XmlDocument xmlDoc = new XmlDocument();
            
            XmlNode declaration = xmlDoc.CreateXmlDeclaration("1.0", "Windows-1252", "yes");
            xmlDoc.AppendChild(declaration);

            XmlNode rootNode = xmlDoc.CreateElement("MCPLogViewer");
            xmlDoc.AppendChild(rootNode);

            XmlNode listaPalavrasnode = xmlDoc.CreateElement("ListaPalavras");
            rootNode.AppendChild(listaPalavrasnode);

            XmlAttribute Destaqueattribute = xmlDoc.CreateAttribute("destaque");
            Destaqueattribute.Value = opDestaque.ToString();
            listaPalavrasnode.Attributes.Append(Destaqueattribute);

            foreach (string palavra in obj)
            {            
                XmlNode palavraNode = xmlDoc.CreateElement("palavra");
                XmlAttribute attribute = xmlDoc.CreateAttribute("cor");
                attribute.Value = "Red";
                palavraNode.Attributes.Append(attribute);
                palavraNode.InnerText = palavra;
                listaPalavrasnode.AppendChild(palavraNode);
            }
            
            XmlNode fonteNode = xmlDoc.CreateElement("Fonte");
            rootNode.AppendChild(fonteNode);

            XmlAttribute fontAttribute = xmlDoc.CreateAttribute("fonte");
            fontAttribute.Value = opFonte ;

            XmlAttribute tamanhoAttribute = xmlDoc.CreateAttribute("tamanho");
            tamanhoAttribute.Value = opTamanho;

            fonteNode.Attributes.Append(fontAttribute);
            fonteNode.Attributes.Append(tamanhoAttribute);

            xmlDoc.Save(pastaConfig + "\\PalavrasImportantes.xml");

        }

        public void XMLDataReader()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.PreserveWhitespace = true;

            try 
            { 
                if(!File.Exists(pastaConfig + "\\PalavrasImportantes.xml"))
                {
                    Directory.CreateDirectory(pastaConfig);
                }
                xmlDoc.Load(pastaConfig + "\\PalavrasImportantes.xml"); 
            }
            catch (System.IO.FileNotFoundException)
            {
                xmlDoc.LoadXml("<?xml version=\"1.0\" encoding=\"Windows-1252\" standalone=\"yes\"?>\n" +
                    "<MCPLogViewer>\n" +
                      "<ListaPalavras destaque=\"0\">\n" +
                        "<palavra cor=\"Red\">prompt_start </palavra>\n" +
                        "<palavra cor=\"Red\">Adding userdata </palavra>\n" +
                        "<palavra cor=\"Red\">prompt_stop </palavra>\n" +
                        "<palavra cor=\"Red\">X-Genesys-</palavra>\n" +
                        "<palavra cor=\"Red\">ANI=sip:</palavra>\n" +
                        "<palavra cor=\"Red\">form_enter :</palavra>\n" +
                        "<palavra cor=\"Red\">form_exit </palavra>\n" +
                        "<palavra cor=\"Red\">goto :#</palavra>\n" +
                      "</ListaPalavras >\n" +
                      "<Fonte fonte=\"Consolas\" tamanho=\"12\"/>" +
                    "</MCPLogViewer>");
            }
            finally
            {
                XmlNodeList ListapalavraNode = xmlDoc.SelectNodes("//MCPLogViewer/ListaPalavras");
                foreach (XmlNode opDestaqueNode in ListapalavraNode)
                {
                    opDestaque = int.Parse(opDestaqueNode.Attributes["destaque"].Value);
                }


                XmlNodeList palavraNodes = xmlDoc.SelectNodes("//MCPLogViewer/ListaPalavras/palavra");
                foreach (XmlNode palavraNode in palavraNodes)
                {
                    ListaPalavrasImportantes.Add(palavraNode.InnerText);
                    //int age = int.Parse(userNode.Attributes["age"].Value);
                    //userNode.Attributes["cor"].Value = NEWCOLOR.ToString();
                }
                XmlNodeList fontesNode = xmlDoc.SelectNodes("//MCPLogViewer/Fonte");
                foreach (XmlNode fonteNode in fontesNode)
                {
                    opFonte = fonteNode.Attributes["fonte"].Value;                        
                    opTamanho = fonteNode.Attributes["tamanho"].Value;
                }
            }
        }


        public object[] encotrarTelefone(RichTextBox textBox, string telefone)
        {
            linhas = new List<string>();
            linhas.AddRange(textBox.Text.Split('\n'));
                        
            List<string> linhasEncontradas = new List<string>();

            foreach (string linha in linhas)
            {
                if (linha.IndexOf(telefone) > 0)
                {

                    linhasEncontradas.Add(linha);
                }
                
            }
            encontrarDebugIDs(linhasEncontradas);

            calllegids.Remove("null");
            calllegids.Remove("00000000-00000000");

            itens = calllegids.ToArray();
                
            
            return itens;
            
        }

        public void carregaPalavrasImportantes()
        {

            if (File.Exists(pastaConfig + "\\PalavrasImportantes.xml"))
            {

                ListaPalavrasImportantes.AddRange(File.ReadAllText(pastaConfig + "\\PalavrasImportantes.xml").Split('\n'));
                File.Delete(pastaConfig + "\\PalavrasImportantes.xml");

            }
            else
            {
                ListaPalavrasImportantes.AddRange(palavrasProcuradas);
            }
        }

        
        public void guardaPalavrasImportantes(List<string> palavras) { 
        
            using (FileStream fs = File.Create(pastaConfig + "\\PalavrasImportantes.xml"))
            {
                if (palavras.Count == 0)
                {
                    File.Delete(pastaConfig + "\\PalavrasImportantes.xml");
                }
                else
                {
                    string arqs = "";
                    foreach (string arq in palavras)
                    {
                        arqs += arqs.Length == 0 ? arq : "\n" + arq;

                    }

                    byte[] info = new UTF8Encoding(true).GetBytes(arqs);
                    fs.Write(info, 0, info.Length);
                    fs.Close();
                }
            }
        }

        public void encontrarDebugIDs(List<string> telefones)
        {
            calllegids = new List<string>();

            foreach(string linha in telefones)
            {
                if(linha.IndexOf("ANI=sip:") > 0 & linha.IndexOf(" DBUG ") > 0)
                {

                    //if(!itens.Contains(linha.Substring(linha.IndexOf("DBUG") + 5, 17)))
                    //{
                    //    itens[count] = linha.Substring(linha.IndexOf("DBUG") + 5, 17);
                    //    count++;
                    //}
                
                    if (!calllegids.Contains(linha.Substring(linha.IndexOf("DBUG") + 5, 17)))
                    {
                        calllegids.Add(linha.Substring(linha.IndexOf("DBUG") + 5, 17));
                    }
                }
            }
        }
    }
}

