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
    public partial class FhistoricoItensExcluidos : Form
    {
        public FhistoricoItensExcluidos()
        {
            InitializeComponent();
        }

        private void FhistoricoExclusao_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ItensRemovidosController controller = new ItensRemovidosController();
                DataTable tabela = controller.listarItensRemovidos();

                if (tabela != null && tabela.Rows.Count > 0)
                {
                    dataGridItensRemovidos.DataSource = tabela;
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
