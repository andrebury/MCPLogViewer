using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MCPLOGViewer.Model
{
    class Manipulation: IManipulation
    {
        //Dictionary<string, string> posicaoCor;
        List<string> linhas;
        object[] itens;
        List<string> calllegids;
        public Manipulation()       {
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

