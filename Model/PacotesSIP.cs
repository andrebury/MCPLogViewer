using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace PacotesSIP_MCP
{
    public class SIPParts
    {
        public string Direction;
        public string RequestType;
        public string Via;
        public string From;
        public string To;
        public string MaxForwards;
        public string CSeq;
        public string CallID;
        public string Contact;
        public string Time;
        public List<string> lista;

        public SIPParts()
        {
            lista = new List<string>();
        }
    }

    class PacoteSIP
    {
        public Dictionary<string, string> pacotes;
        public string textoIniciador = "Trc 33009 INFO 00000000-00000000 ";
        private string log;
        public PacoteSIP(string log)
        {
            this.log = log;

        }



        public void separarPacotes()
        {
            pacotes = new Dictionary<string, string>();

            foreach (string linha in log.Split('\n'))
            {
                if (linha.Contains("CallRef="))
                {
                    //pacotes.Add(linha.Substring(linha.IndexOf("CallRef=") + 8, 44),pacote);
                    pacotes.Add(linha.Substring(linha.IndexOf("CM_MSG_LMCC_CALLINOFFERED - ") + 28, 17),
                        linha.Substring(linha.IndexOf("CallRef=") + 8, 44));
                }
            }
        }

        public Dictionary<string, List<SIPParts>> armazenarPacotes()
        {
            //transforma o texto em lista para iterar sobre as linhas
            List<string> logLista = new List<string>();
            logLista.AddRange(log.Split('\n'));


            //instancia o dicionario pacotao, onde vão todos os pacotes selecionados
            Dictionary<string, List<SIPParts>> pacotao = new Dictionary<string, List<SIPParts>>();

            //contador das linhas gerais
            int count = -1;

            //para cada linha na log inteira
            foreach (string linha in logLista)
            {
                count++;

                //se a linha for inicio de pacote sip
                if (linha.Contains(textoIniciador))
                {

                    SIPParts sIP = new SIPParts();
                    sIP.Time = linha.Substring(0, 24);
                    sIP.Direction = linha.Substring(linha.IndexOf(textoIniciador) + 47, (linha.IndexOf(':', linha.IndexOf(textoIniciador))) - (linha.IndexOf(textoIniciador) + 47));

                    sIP.RequestType = linha.Substring(linha.IndexOf(sIP.Direction) + sIP.Direction.Length + 1);


                    //atriui o contador de linhas gerais ao contador de linhas do pacote individual
                    int kont = count;


                    sIP.lista.Add(linha.Substring(linha.IndexOf(textoIniciador) + 47));
                    do
                    {

                        kont++;
                        if (kont == logLista.Count)
                        {
                            break;
                        }
                        Regex regex = new Regex("([0-9]{4}-[0-9]{2}-[0-9]{2})");

                        //resolver o outofrange

                        if ((!regex.IsMatch(logLista[kont])) & (logLista[kont].IndexOf(textoIniciador) < 0))
                        {

                            sIP.lista.Add(logLista[kont]);

                            //Via        From        To        MaxForwards        CSeq                Contact

                            if (logLista[kont].Contains("Call-ID: "))
                            {
                                sIP.CallID = logLista[kont].Substring("Call-ID: ".Length);
                                sIP.CallID = sIP.CallID.Substring(0, sIP.CallID.IndexOf("@"));
                            }

                            if (logLista[kont].Contains("From: "))
                            {
                                sIP.From = logLista[kont].Substring("From: ".Length);

                            }

                            if (logLista[kont].Contains("To: "))
                            {
                                sIP.To = logLista[kont].Substring("To: ".Length);

                            }


                            if (logLista[kont].Contains("Max-Forwards: "))
                            {
                                sIP.MaxForwards = logLista[kont].Substring("Max-Forwards: ".Length);

                            }

                            if (logLista[kont].Contains("CSeq: "))
                            {
                                sIP.CSeq = logLista[kont].Substring("CSeq: ".Length);

                            }

                            if (logLista[kont].Contains("Contact: "))
                            {
                                sIP.Contact = logLista[kont].Substring("Contact: ".Length);

                            }
                        }
                        else
                        {
                            if (pacotao.ContainsKey(sIP.CallID))
                            {
                                List<SIPParts> listTemp = new List<SIPParts>();

                                pacotao.TryGetValue(sIP.CallID, out listTemp);
                                listTemp.Add(sIP);

                                pacotao.Remove(sIP.CallID);
                                pacotao.Add(sIP.CallID, listTemp);
                            }
                            else
                            {
                                List<SIPParts> listaPacotes = new List<SIPParts>();
                                listaPacotes.Add(sIP);
                                pacotao.Add(sIP.CallID, listaPacotes);
                            }
                            break;

                        }
                    } while (true);
                }

            }
            return pacotao;
        }
    }
}
