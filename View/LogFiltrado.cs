using MCPLOGViewer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCPLOGViewer.View
{
    public partial class LogFiltrado : Form
    {
        List<string> texto;
        Manipulation manipulation;
        string buscado;
        string logFileName;

        public LogFiltrado(List<string> texto, string buscado, Manipulation manipulation)
        {
            InitializeComponent();
            this.texto = texto;
            this.buscado = buscado;
            this.manipulation = manipulation;
        }

        private void LogFiltrado_Load(object sender, EventArgs e)
        {
            if (manipulation.opDestaque == 1)
            {
                buscaCor2();
            }
            else 
            { 
                buscaSemCor(); 
            }

            }

        private void buscaSemCor()
        {

            List<string> linhasEncontradas = new List<string>();
            foreach (string linha in texto)
            {
                if (linha.ToLower().IndexOf(buscado.ToLower()) > 0)
                {

                    linhasEncontradas.Add(linha + "\n");
                }
            }
            foreach (string linha in linhasEncontradas)
            {
                txt_logFiltrado.AppendText(linha);
            }
            txt_logFiltrado.SelectionStart = 0;
            txt_logFiltrado.Focus();

        }

        private void buscaCor2()
        {

            List<string> linhasEncontradas = new List<string>();
            foreach (string linha in texto)
            {
                if (linha.ToLower().IndexOf(buscado.ToLower()) > 0)
                {

                    linhasEncontradas.Add(linha + "\n");
                }
            }
            foreach (string linha in linhasEncontradas)
            {
                txt_logFiltrado.AppendText(linha);
                int tamTexto = txt_logFiltrado.TextLength;
            }

            foreach(string word in manipulation.ListaPalavrasImportantes)
            {
                int posWord = 0;
                while(true)
                {
                    int posWordtemp = txt_logFiltrado.Find(word, posWord + 2, RichTextBoxFinds.MatchCase);
                    if(posWordtemp >= 0)
                    {
                        posWord = posWordtemp;
                        txt_logFiltrado.Select(posWord, word.Length);
                        txt_logFiltrado.SelectionColor = Color.Red;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            txt_logFiltrado.SelectionStart = 0;
            txt_logFiltrado.Focus();
        }



        private void buscaCor()
        {

            List<string> linhasEncontradas = new List<string>();
            foreach (string linha in texto)
            {
                if (linha.ToLower().IndexOf(buscado.ToLower()) > 0)
                {

                    linhasEncontradas.Add(linha + "\n");
                }
            }
            foreach (string linha in linhasEncontradas)
            {                
                txt_logFiltrado.AppendText(linha);
                int tamTexto = txt_logFiltrado.TextLength;
                manipulation.ListaPalavrasImportantes.Add(buscado);
                foreach (string word in manipulation.ListaPalavrasImportantes)
                {
                    int posWord = 0;
                    bool encontrou = true;
                    while (encontrou == true)
                    {
                        if (posWord == 0)
                        {
                            posWord = txt_logFiltrado.Find(word.Trim(), tamTexto, RichTextBoxFinds.MatchCase);
                        }
                        else
                        {
                            posWord = txt_logFiltrado.Find(word.Trim(), posWord + word.Length, RichTextBoxFinds.MatchCase);
                        }


                        if (posWord >= 0)
                        {
                            txt_logFiltrado.Select(posWord, word.Length);
                            txt_logFiltrado.SelectionColor = Color.Red;
                        }
                        else
                        {
                            encontrou = false;
                        }
                    }
                }
                manipulation.ListaPalavrasImportantes.Remove(buscado);
                txt_logFiltrado.SelectionStart = 0;
                txt_logFiltrado.Focus();
            }
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveLogFile();
        }

        private void aumentarFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt_logFiltrado.Text.Length == 0)
            {
                MessageBox.Show("Favor Abrir um arquivo!");
            }
            else
            {
                Font font = new Font("Consolas", txt_logFiltrado.Font.Size + 1);
                txt_logFiltrado.Font = font;
            }
        }

        private void fontSizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (txt_logFiltrado.Text.Length == 0)
            {
                MessageBox.Show("Favor Abrir um arquivo!");
            }
            else
            {
                Font font = new Font("Consolas", txt_logFiltrado.Font.Size - 1);
                txt_logFiltrado.Font = font;
            }
        }

        private void abrirNoNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Guid guidFilename = System.Guid.NewGuid();
            

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = Environment.GetEnvironmentVariable("temp").ToString() + "/" + guidFilename.ToString() + ".log";
            logFileName = saveFileDialog1.FileName.ToString();
            //MessageBox.Show(saveFileDialog1.FileName);
            Stream myStream;
            if ((myStream = saveFileDialog1.OpenFile()) != null)
            {
                using (StreamWriter sw = new StreamWriter(myStream))
                {
                    string[] linhas = txt_logFiltrado.Lines;

                    for (int Contador = 0; Contador < linhas.Length; Contador++)
                    {
                        sw.WriteLine(linhas[Contador]);
                    }
                    sw.Close();
                }
                myStream.Close();
            }
            Process myProcess = new Process();
            Process.Start("notepad++.exe", logFileName);

        }

        private void SaveLogFile()
        {
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "log";
            saveFileDialog1.FileName = buscado;
            saveFileDialog1.RestoreDirectory = true;


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream myStream;
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {

                    using (StreamWriter sw = new StreamWriter(myStream))
                    {
                        string[] linhas = txt_logFiltrado.Lines;

                        for (int Contador = 0; Contador < linhas.Length; Contador++)
                        {
                            sw.WriteLine(linhas[Contador]);
                        }
                        sw.Close();
                    }


                    myStream.Close();
                }
            }
        }

        private void txt_logFiltrado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
