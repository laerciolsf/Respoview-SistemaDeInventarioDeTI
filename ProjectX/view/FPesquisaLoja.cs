using ProjectX.controller;
using ProjectX.model;
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
        public Loja selecionado;
        public FPesquisaLoja()
        {
            InitializeComponent();
            selecionado = new Loja();
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

        private void botaoConfirmar_Click(object sender, EventArgs e)
        {
            if (GridLoja.Rows.Count > 0)
            {
                selecionado.id = int.Parse(GridLoja.CurrentRow.Cells[0].Value.ToString());
                selecionado.loja = GridLoja.CurrentRow.Cells[1].Value.ToString();

            }
            Close();
        }

        private void GridLoja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
