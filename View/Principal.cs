﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MCPLOGViewer.Model;

namespace MCPLOGViewer.View
{
    public partial class Principal : Form
    {
        List<string> texto;
        Manipulation manipulation;
        string lido;
        public Preferencias palavrasImportantes;
        int buscafocus;
        public Principal()
        {
            InitializeComponent();
            manipulation = new Manipulation();
            texto = new List<string>();
        }
        
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
               
        public void abrirArquivo(string fileSelected)
        {
            texto.Clear();
            txt_Logtext.Clear();
            lido = "";

                using (StreamReader objReader = new StreamReader(fileSelected))
                {
                    if (File.Exists(fileSelected))
                    {
                        //txt_Logtext.AppendText(objReader.ReadToEnd());
                        lido = objReader.ReadToEnd();
                        objReader.Close();
                    }
                }
            txt_Logtext.AppendText(lido);
            lido = "";
            adicionaTexto();
        }

        public async void abrirArquivo2(string fileSelected)
        {
            texto.Clear();
            txt_Logtext.Clear();
            lido = "";
            await Task.Run(() =>
            {
                using (StreamReader objReader = new StreamReader(fileSelected))
                {
                    if (File.Exists(fileSelected))
                    {
                        //txt_Logtext.AppendText(objReader.ReadToEnd());
                        lido = objReader.ReadToEnd();
                        objReader.Close();
                    }
                }
            });
            txt_Logtext.AppendText(lido);
            lido = "";
            adicionaTexto();
        }

        public void busca(string buscado)
        {

            //if (texto.Count <= 0)
            //{
            //    adicionaTexto();
            //}

            LogFiltrado logFiltrado = new LogFiltrado(texto, buscado, manipulation);
            logFiltrado.Show();

        }


        public void adicionaTexto()
        {
            // await Task.Run(Action() 
            texto.Clear();
            texto.AddRange(txt_Logtext.Text.Split('\n'));
        }

        private void abrirArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\Meus Documentos";
            openFileDialog1.Title = "Localizar Log";
            openFileDialog1.DefaultExt = "log";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != "")
                {
                    float tamFloat = float.Parse(manipulation.opTamanho);
                    Font font = new Font(manipulation.opFonte, tamFloat);
                    //Font font = new Font(manipulation.opFonte, manipulation.opTamanho);
                    txt_Logtext.Font = font;
                    
                    abrirArquivo(openFileDialog1.FileName.ToString());
                }
                else
                {
                    MessageBox.Show("Favor selecionar o texto!");
                }
            }
        }

                     
        private void btn_busca_Click(object sender, EventArgs e)
        {
            //busca
            if(txt_busca.Text == "")
            {
                
                MessageBox.Show("Favor escrever algo no campo \"Buscar por\" !");

            }else if (txt_Logtext.Text == "")
            {
                MessageBox.Show("Favor abrir primeiro um arquivo!");
            }

            else
            {
                busca(txt_busca.Text);
            }
        }

       
        private void btn_juntarLigacoes_Click(object sender, EventArgs e)
        {
            lst_debugIDs.Items.Clear();
            lst_debugIDs.Items.AddRange(manipulation.encotrarTelefone(txt_Logtext, txt_busca.Text));
            
        }

        private void lst_debugIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            busca(lst_debugIDs.SelectedItem.ToString());
            
        }

        private void fecharArqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_Logtext.Clear();
            texto.Clear();
        }

        private void mn_sair_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //toolStripStatusLabel2.Text = "";
        }        

        private void aumentarFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt_Logtext.Text.Length == 0)
            {
                MessageBox.Show("Favor Abrir um arquivo!");
            }
            else
            {                
                Font font = new Font("Consolas", txt_Logtext.Font.Size + 1);
                txt_Logtext.Font = font;
            }
        }

        private void diminuirFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt_Logtext.Text.Length == 0)
            {
                MessageBox.Show("Favor Abrir um arquivo!");
            }
            else
            {
                Font font = new Font("Consolas", txt_Logtext.Font.Size - 1);
                txt_Logtext.Font = font;
            }
        }

        private void separarPacotesSIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MapaSIP mapaSIP = new MapaSIP(txt_Logtext.Text);
            mapaSIP.Show();
            
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }


        private void palavrasImportantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            palavrasImportantes = new Preferencias(manipulation);
            palavrasImportantes.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            chk_MatchCase.Checked = true;
        }

        private void btn_buscarFoco_Click(object sender, EventArgs e)
        {
            buscafocus++;
            if(chk_MatchCase.Checked == true)
            {
                buscafocus = txt_Logtext.Find(txt_buscarFoco.Text, buscafocus, RichTextBoxFinds.MatchCase);
            }
            else
            {
                buscafocus = txt_Logtext.Find(txt_buscarFoco.Text, buscafocus, RichTextBoxFinds.None);
            }
            if(buscafocus >= 0)
            {
                txt_Logtext.Select(buscafocus, txt_buscarFoco.Text.Length);
                txt_Logtext.Focus();
            }
            else
            {
                MessageBox.Show("Não foi encontrado o valor da busca no texto!");
            }
            
            
        }

        private void txt_buscarFoco_TextChanged(object sender, EventArgs e)
        {
            buscafocus = -1;
        }
    }  
}
