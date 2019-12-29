using MCPLOGViewer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCPLOGViewer.View
{
    public partial class PalavrasImportantes : Form
        
    {
        Manipulation manipulation;
        public int opDestaque;
        public PalavrasImportantes(Manipulation manipulation)
        {
            InitializeComponent();

            this.manipulation = manipulation;
            
            
        }     

        private void PalavrasImportantes_Load(object sender, EventArgs e)
        {

            lst_palavras.Items.AddRange(manipulation.ListaPalavrasImportantes.ToArray());
            rbt_sem_destaque.Checked = true;
        }

        private void btn_adcicionar_Click(object sender, EventArgs e)
        {
            if (!lst_palavras.Items.Contains(txt_palavra.Text))
            {
                lst_palavras.Items.Add(txt_palavra.Text);
                manipulation.ListaPalavrasImportantes.Add(txt_palavra.Text);
            }
            else
            {
                MessageBox.Show("Palavra já existe no dicionário!");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if(lst_palavras.SelectedIndex >= 0)
            {
                lst_palavras.Items.RemoveAt(lst_palavras.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Favor selecionar primeiro uma palavra do dicionário!");
            }
        }


        private void PalavrasImportantes_Disposed(object sender, EventArgs e)
        {
            
            manipulation.XMLDataWriter(manipulation.ListaPalavrasImportantes.ToArray());
        }

        private void lst_palavras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbt_destaque_CheckedChanged(object sender, EventArgs e)
        {
            manipulation.opDestaque = 1;
            opDestaque = 1;
        }


        private void rbt_sem_destaque_CheckedChanged(object sender, EventArgs e)
        {
            manipulation.opDestaque = 0;
            opDestaque = 0;
        }

        private void txt_palavra_Click(object sender, EventArgs e)
        {
            if(txt_palavra.Text == "Adicionar palavras")
            {
                txt_palavra.Text = "";
            }
        }
    }
}
