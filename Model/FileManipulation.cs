using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MCPLOGViewer.Model
{
    class FileManipulation
    {
        public async void abrirArquivo(string fileSelected)
        {
           
            using (StreamReader objReader = new StreamReader(fileSelected))
            {
                if (File.Exists(fileSelected))
                {
                    //txt_Logtext.AppendText(objReader.ReadToEnd());
                    await Task.Run(() => lerArquivo(objReader));
                }
            }
        }

        public async void lerArquivo(StreamReader objReader)
        {
            string lido = await objReader.ReadToEndAsync();
            //txt_Logtext.AppendText(lido);
            adicionaTexto();
        }


        public void adicionaTexto()
        {
            // await Task.Run(Action() 

            //texto.AddRange(txt_Logtext.Text.Split('\n'));

        }
    }
}

