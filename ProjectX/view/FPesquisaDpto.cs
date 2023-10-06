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
    public partial class FPesquisaDpto : Form
    {
        public Dpto selecionado;
        public FPesquisaDpto()
        {
            InitializeComponent();
            selecionado = new Dpto();
        }

        private void FPesquisaDpto_Load(object sender, EventArgs e)
        {

        }

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisar.Text + "%";

            dptoController controller = new dptoController();


            GridDpto.DataSource = controller.buscaPorNome(nome);

            if (GridDpto.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum fornecedor encontrado com este nome");
                GridDpto.DataSource = controller.listarDpto();
            }
        }

        private void botaoConfirmar_Click(object sender, EventArgs e)
        {
            if (GridDpto.Rows.Count > 0)
            {
                selecionado.id = int.Parse(GridDpto.CurrentRow.Cells[0].Value.ToString());
                selecionado.dpto = GridDpto.CurrentRow.Cells[1].Value.ToString();

            }
            Close();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridDpto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
