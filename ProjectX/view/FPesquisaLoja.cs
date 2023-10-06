using ProjectX.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectX.view
{
    public partial class FPesquisaLoja : Form
    {
        public FPesquisaLoja()
        {
            InitializeComponent();
        }

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisar.Text + "%";

            lojaController controller = new lojaController();


            GridLoja.DataSource = controller.buscaPorNome(nome);

            if (GridLoja.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum loja encontrado com este nome");
                GridLoja.DataSource = controller.listarLoja();
            }
        }
    }
}
