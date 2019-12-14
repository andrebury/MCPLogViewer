using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Threading;
using MCPLOGViewer.Model;

namespace MCPLOGViewer.View
{
    public partial class Form1 : Form
    {
        public string fileSelected;
        int start = 0;
        int indexOfSearchText = 0;
        List<string> texto;
        string[] palavrasProcuradas = {"prompt_start", "Adding userdata", "prompt_stop","ACK", "PRACK", "REFER","UPDATE", "CANCEL", "INFO", "NOTIFY", "MESSAGE","INVITE", "BYE" , "TRYING" , "OPTIONS" , "200 OK" , "X-Genesys-" , "ANI=sip:"};
        Manipulation manipulation;
        List<string> arquivos;
        string nomeLogsRecentes = Environment.GetEnvironmentVariable("appdata").ToString() + "/MCPLogViewer/";
        public Form1()
        {
            InitializeComponent();
            manipulation = new Manipulation();
            texto = new List<string>();
            arquivos = new List<string>();
        }

        public void carregarArquivos(string modo)
        {
            
            if (modo == "abertura")
            {
                if(File.Exists(nomeLogsRecentes + "arquivosRecentes.txt"))
                {
                    arquivos.AddRange(File.ReadAllText(nomeLogsRecentes + "arquivosRecentes.txt").Split(';'));
                    lst_files.BeginUpdate();
                    lst_files.Items.AddRange(arquivos.ToArray());
                    lst_files.EndUpdate();
                }
                
            }
            else 
            {
                if(!File.Exists(nomeLogsRecentes))
                {
                    Directory.CreateDirectory(nomeLogsRecentes);
                }

                
                using(FileStream fs = File.Create(nomeLogsRecentes + "arquivosRecentes.txt"))
                {
                    if(lst_files.Items.Count == 0)
                    {
                        fs.Close();
                        File.Delete(nomeLogsRecentes + "arquivosRecentes.txt");
                    }
                    else
                    {                    
                        string arqs = "";
                        foreach(string arq in arquivos)
                        {
                            arqs += arq + ";";
                        }

                        byte[] info = new UTF8Encoding(true).GetBytes(arqs);
                        fs.Write(info, 0, info.Length);
                        fs.Close();
                    }
                }
                
            }
        }


        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void busca()
        {
            

            txt_Logtext.Clear();
            int count = 0;
            int kont = 0;
            List<string> linhasEncontradas = new List<string>();
            foreach (string linha in texto)
            {
                kont++;
                if (linha.ToLower().IndexOf(txt_busca.Text.ToLower()) > 0)
                {

                    linhasEncontradas.Add(kont.ToString() + ": " + linha + "\n");
                    count++;
                }
            }
            foreach (string linha in linhasEncontradas)
            {
                txt_Logtext.AppendText(linha);
            }
            MessageBox.Show("Encontrado " + count.ToString() + " elementos.");
        }

        public async void abrirArquivo()
        {
            try
            {

                txt_Logtext.Clear();
                string lido = "";

                await Task.Run(() =>
                {
                    using (StreamReader objReader = new StreamReader(fileSelected))
                    {
                        if (File.Exists(fileSelected))
                        {
                            //txt_Logtext.AppendText(objReader.ReadToEnd());
                            lido = objReader.ReadToEnd();
                        }
                        objReader.Close();
                    }
                });

                txt_Logtext.AppendText(lido);
                adicionaTexto();

            }
            catch
            {
                MessageBox.Show("Erro para abrir arquivo");
            }                    
        }

   

        public void busca(string buscado)
        {           

            txt_Logtext.Clear();

            int count = 0;
            int kont = 0;
            List<string> linhasEncontradas = new List<string>();
            foreach (string linha in texto)
            {
                kont++;
                if (linha.ToLower().IndexOf(buscado.ToLower()) > 0)
                {

                    linhasEncontradas.Add(kont.ToString() + ": " + linha + "\n");
                    count++;
                }
            }
            foreach (string linha in linhasEncontradas)
            {
                txt_Logtext.AppendText(linha);
            }
            colorirTexto();
            MessageBox.Show("Encontrado " + count.ToString() + " Elementos.");
        }

        public void colorirTexto()
        {
            
            Dictionary<int, List<int>> indiceParaCor = new Dictionary<int, List<int>>();
            int count = 0;

            bool encontrou = true;
            foreach (string txtSearch in palavrasProcuradas)                
            {
                encontrou = true;
                int startindex = 0;
                start = 0;
                indexOfSearchText = 0;
                while (encontrou == true)
                {
                    
                    startindex = FindMyText(txtSearch.Trim(), start, txt_Logtext.Text.Length);

                    // If string was found in the RichTextBox, highlight it
                    if (startindex >= 0)
                    {
                        // Set the highlight color as red
                    
                        // Find the end index. End Index = number of characters in textbox
                        int endindex = txtSearch.Length;
                        // Highlight the search string

                        
                        List<int> startend = new List<int>();
                        startend.Add(startindex);
                        startend.Add(endindex);
                        indiceParaCor.Add(count, startend);
                        count++;
                        //txt_Logtext.Select(startindex, endindex);
                        //txt_Logtext.SelectionColor = Color.Red;
                        // mark the start position after the position of
                        // last search string
                        start = startindex + endindex;
                    }
                    else
                    {
                        encontrou = false;
                    }
                }
            }

            highlightText(indiceParaCor);


        }

        public void highlightText(Dictionary<int, List<int>> indiceParaCor)
        {
            for(int a = 0; a < indiceParaCor.Count; a++)
            {
                indiceParaCor.TryGetValue(a, out List<int> tamanho);

                txt_Logtext.Select(tamanho[0], tamanho[1]);
                txt_Logtext.SelectionColor = Color.Red;
            }
        }

        public int FindMyText(string txtToSearch, int searchStart, int searchEnd)
        {
            // Unselect the previously searched string
            if (searchStart > 0 && searchEnd > 0 && indexOfSearchText >= 0)
            {
                txt_Logtext.Undo();
            }

            // Set the return value to -1 by default.
            int retVal = -1;

            // A valid starting index should be specified.
            // if indexOfSearchText = -1, the end of search
            if (searchStart >= 0 && indexOfSearchText >= 0)
            {
                // A valid ending index
                if (searchEnd > searchStart || searchEnd == -1)
                {
                    // Find the position of search string in RichTextBox
                    indexOfSearchText = txt_Logtext.Find(txtToSearch, searchStart, searchEnd, RichTextBoxFinds.MatchCase);
                    // Determine whether the text was found in richTextBox1.
                    if (indexOfSearchText != -1)
                    {
                        // Return the index to the specified search text.
                        retVal = indexOfSearchText;
                    }
                }
            }
            return retVal;
        }

        public void adicionaTexto()
        {
            // await Task.Run(Action() 

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
                lst_files.BeginUpdate();
                lst_files.Items.Add(openFileDialog1.FileName);
                arquivos.Add(openFileDialog1.FileName);
                lst_files.EndUpdate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregarArquivos("abertura");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void lst_files_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (fileSelected != lst_files.SelectedItem.ToString()) { 
                
            //        fileSelected = lst_files.SelectedItem.ToString();
            //    }
            //}
            //catch
            //    {
            //        MessageBox.Show("Favor selecionar o texto!");
            //    }
            
        }


        private void lst_files_SelectedIndexDoubleClick(object sender, EventArgs e)
        {
            try
            {
                fileSelected = lst_files.SelectedItem.ToString();
                toolStripStatusLabel2.Text = fileSelected;

                abrirArquivo();
                
            }
            catch
            {
                MessageBox.Show("Favor selecionar o texto!");
            }

            
            //colorirTexto();

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
                busca();
            }
        }

        private void txt_busca_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txt_Logtext_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_UnLoad(object sender, EventArgs e)
        {
            carregarArquivos("fechamento");
        }

        

        private void btn_corComandos_Click(object sender, EventArgs e)
        {
            if (txt_Logtext.Text.Length != 0)
            {
                colorirTexto();
            }
        }

        private void btn_juntarLigacoes_Click(object sender, EventArgs e)
        {
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
            toolStripStatusLabel2.Text = "";
        }

        private void abrirPastaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string folderPath = "";
            FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
            if (directchoosedlg.ShowDialog() == DialogResult.OK)
            {
                folderPath = directchoosedlg.SelectedPath;
            
                arquivos.AddRange(Directory.GetFiles(folderPath, "*.log"));
                        
                lst_files.BeginUpdate();
                lst_files.Items.AddRange(arquivos.ToArray());
                lst_files.EndUpdate();
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lst_files.Items.Clear();
        }
    }
}
