using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MCPLOGViewer.Model
{
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

        public Manipulation()
        {
            ListaPalavrasImportantes = new List<string>();
            
            carregaPalavrasImportantes();
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

            if (File.Exists(pastaConfig + "\\PalavrasImportantes.txt"))
            {

                ListaPalavrasImportantes.AddRange(File.ReadAllText(pastaConfig + "\\PalavrasImportantes.txt").Split('\n'));
                File.Delete(pastaConfig + "\\PalavrasImportantes.txt");

            }
            else
            {
                ListaPalavrasImportantes.AddRange(palavrasProcuradas);
            }
        }
         
        public void criaTXTPalavrasImportantes()
        {
        
            if (!File.Exists(pastaConfig))
            {
                Directory.CreateDirectory(pastaConfig);               
                
            }

            ListaPalavrasImportantes.AddRange(palavrasProcuradas);
            guardaPalavrasImportantes(ListaPalavrasImportantes);

        }
        
        public void guardaPalavrasImportantes(List<string> palavras) { 
        
            using (FileStream fs = File.Create(pastaConfig + "\\PalavrasImportantes.txt"))
            {
                if (palavras.Count == 0)
                {
                    File.Delete(pastaConfig + "\\PalavrasImportantes.txt");
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

