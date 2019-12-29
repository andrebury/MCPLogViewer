using PacotesSIP_MCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCPLOGViewer.View
{
    public partial class MapaSIP : Form
    {
        string lido;
        PacoteSIP pacoteSIP;
        Dictionary<string, List<SIPParts>> pacotao;
        string debugid;
        List<SIPParts> listapacotes;

        public MapaSIP(string lido)
        {
            this.lido = lido;
            InitializeComponent();

        }

        private void openSIPDialogs()
        {
            pacotao = new Dictionary<string, List<SIPParts>>();

            pacoteSIP = new PacoteSIP(lido);
            pacoteSIP.separarPacotes();
            pacotao = pacoteSIP.armazenarPacotes();


            if (pacoteSIP.pacotes.Count > 0)
            {
                lst_debugids.Items.AddRange(pacoteSIP.pacotes.Keys.ToArray());
                lst_debugids.Visible = true;
            }
        }
        private async void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MapaSIP_Load(object sender, EventArgs e)
        {
            lst_debugids.Visible = false;
            lst_infos.Visible = false;
            txt_SipText.Visible = false;
            openSIPDialogs();
        }

        private void lst_debugids_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_SipText.Clear();
            debugid = lst_debugids.SelectedItem.ToString();

            if (pacoteSIP.pacotes.ContainsKey(debugid))
            {

                pacotao.TryGetValue(pacoteSIP.pacotes[debugid], out listapacotes);
                lst_infos.Items.Clear();
                lst_infos.Visible = true;
                foreach (SIPParts sip in listapacotes)
                {
                    string direction = "";
                    string RequestType = "";

                    if (sip.RequestType.Contains("Trying"))
                    {
                        RequestType = "SIP/2.0 100 Trying";
                    }
                    else if (sip.RequestType.Contains("200 OK"))
                    {
                        RequestType = "SIP/2.0 200 OK";
                    }
                    else
                    {
                        RequestType = sip.RequestType.Substring(0, sip.RequestType.IndexOf(" ", 1)).Trim();
                    }

                    if (sip.Direction.Contains("sent"))
                    {
                        direction = ">>>>";
                    }
                    else
                    {
                        direction = "<<<<";
                    }

                    

                    lst_infos.Items.Add(direction + " - " + sip.Time + " - " + RequestType).ToString();


                    //string info = "";
                    //foreach(string linha in sip.lista)
                    //{
                    //    info += linha;
                    //}
                    //MessageBox.Show(info);
                }

            }
        }

        private void lst_infos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_SipText.Visible = true;
            txt_SipText.Clear();


            foreach (string linha in listapacotes[lst_infos.SelectedIndex].lista)
            {
                txt_SipText.AppendText(linha + '\n');
            }


            //lst_infos.SelectedIndex
        }
    }
}
