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
        string[] palavrasProcuradas = { "prompt_start", "Adding userdata", "prompt_stop", "X-Genesys-", "ANI=sip:", "form_enter :", "form_exit ", "goto :#" };
        public Data data;

        public Manipulation()
        {
            ListaPalavrasImportantes = new List<string>();

            //carregaPalavrasImportantes();
            data = new Data();
            carregaConfigFile();
        }
        

        public void carregaConfigFile()
        {
            if (File.Exists(pastaConfig + "\\PalavrasImportantes.xml"))
            {
                XMLDataReader();
                
            }
            else
            {
                ListaPalavrasImportantes.AddRange(palavrasProcuradas);
            }
        }

        public void XMLDataWriter(string[] obj)
        {
            File.Delete(pastaConfig + "\\PalavrasImportantes.xml");

            XmlDocument xmlDoc = new XmlDocument();
            
            XmlNode declaration = xmlDoc.CreateXmlDeclaration("1.0", "Windows-1252", "yes");
            xmlDoc.AppendChild(declaration);

            XmlNode rootNode = xmlDoc.CreateElement("ListaPalavras");
            xmlDoc.AppendChild(rootNode);

            foreach(string palavra in obj)
            {            
                XmlNode userNode = xmlDoc.CreateElement("palavra");
                XmlAttribute attribute = xmlDoc.CreateAttribute("cor");
                attribute.Value = "Red";
                userNode.Attributes.Append(attribute);
                userNode.InnerText = palavra;
                rootNode.AppendChild(userNode);
            }
            xmlDoc.Save(pastaConfig + "\\PalavrasImportantes.xml");

        }

        public void XMLDataReader()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(pastaConfig + "\\PalavrasImportantes.xml");
            XmlNodeList userNodes = xmlDoc.SelectNodes("//ListaPalavras/palavra");
            ListaPalavrasImportantes.Clear();
            foreach (XmlNode userNode in userNodes)
            {
                ListaPalavrasImportantes.Add(userNode.InnerText);
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

