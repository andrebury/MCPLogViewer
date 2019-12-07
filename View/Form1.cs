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
using MCPLOGViewer.Model;

namespace MCPLOGViewer.View
{
    public partial class Form1 : Form
    {
        public string fileSelected;
        string[] linhas;
        List<string> logInfo;

        public Form1()
        {
            InitializeComponent();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
                lst_files.BeginUpdate();
                lst_files.Items.Add(openFileDialog1.FileName);
                lst_files.EndUpdate();                
            }
            btn_openFile.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logInfo = new List<string>();
            btn_openFile.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrir Arquivo
            
            if (fileSelected != null)
            {
                txt_Logtext.Clear();
                linhas = File.ReadAllLines(fileSelected);
                foreach (string linha in linhas)
                {

                    txt_Logtext.Text += (linha + "\n");

                }

            }
            else
            {
                MessageBox.Show("Selecione um arquivo primeiro!");
            }


        }

        private void lst_files_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileSelected = lst_files.SelectedItem.ToString();

        }


        private void lst_files_SelectedIndexDoubleClick(object sender, EventArgs e)
        {
            fileSelected = lst_files.SelectedItem.ToString();
            //Abrir Arquivo

            if (fileSelected != null)
            {
                txt_Logtext.Clear();
                linhas = File.ReadAllLines(fileSelected);
                foreach (string linha in linhas)
                {

                    txt_Logtext.Text += (linha + "\n");

                }

            }
            else
            {
                MessageBox.Show("Selecione um arquivo primeiro!");
            }
        }
        


        private void Form1_Resize(object sender, System.EventArgs e)
        {
            Control control = (Control)sender;

            // Ensure the Form remains square (Height = Width).
            if (control.Size.Height != control.Size.Width)
            {
                //control.Size = new Size(control.Size.Width, control.Size.Width);
                MessageBox.Show(control.Size.Width + " " + control.Size.Height);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //busca
            if(txt_busca.Text == "")
            {
                
                MessageBox.Show("Favor escrever algo no campo \"Buscar por\" !");

            }else if (txt_Logtext.Text == "")
            {
                MessageBox.Show("Favor abra primeiro um arquivo!");
            }

            else
            {
                txt_Logtext.Clear();
                int count = 0;
                foreach (string linha in linhas)
                {
                    if(linha.ToLower().IndexOf(txt_busca.Text.ToLower()) > 0)
                    {
                        txt_Logtext.Text += linha + "\n";
                        count ++;

                        
                    }
                }

                MessageBox.Show("Encontrado " + count.ToString() + " Elementos.");


            }
        }

        private void txt_busca_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
