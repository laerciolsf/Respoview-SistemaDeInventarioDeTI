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
    public partial class FDpto : Form
    {
        private string status = "";
        public FDpto()
        {
            InitializeComponent();
        }
        public void desabilitarCampos()
        {
            txtIdDpto.Enabled = false;
            txtNomeDpto.Enabled = false;

            //desabilita os botoes
            botaoSalvar.Enabled = false;
            botaoEditar.Enabled = false;
            botaoExcluir.Enabled = false;
        }

        public void habilitarCampos()
        {
            //txtId.Enabled = false;
            txtNomeDpto.Enabled = true;
            botaoSalvar.Enabled = true;
        }

        public void limparCampos()
        {
            txtIdDpto.Text = String.Empty;
            txtNomeDpto.Text = String.Empty;

            txtNomeDpto.Focus();
        }






        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            limparCampos();
            status = "inserindo";
            tabControl1.SelectedTab = tabDados;
        }

        private void FDpto_Load(object sender, EventArgs e)
        {
            desabilitarCampos();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Dpto obj = new Dpto();

            obj.dpto = txtNomeDpto.Text;

            dptoController controller = new dptoController();

            if (status == "inserindo")
            {
                controller.cadastrarDpto(obj);
                status = "";
            }
            else if (status == "alterando")
            {
                obj.id = int.Parse(txtIdDpto.Text);
                controller.alterarDpto(obj);
                status = "";

            }
            limparCampos();
            desabilitarCampos();
            dataGridView1.DataSource = controller.listarDpto();

            tabControl1.SelectedTab = tabPesquisa;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = "%" + textBox1.Text + "%";

            dptoController controller = new dptoController();
            dataGridView1.DataSource = controller.buscaPorNome(nome);

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum fornecedor encontrado com este nome");
                dataGridView1.DataSource = controller.listarDpto();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if para evitar o bug do botao novo
            if (status == "inserindo")
            {
                desabilitarCampos();
                status = "";
            }

            //Pegar os dados da grid para os campos
            txtIdDpto.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNomeDpto.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            //habilita os botões
            botaoEditar.Enabled = true;
            botaoExcluir.Enabled = true;
            //Vai para a aba de dados
            tabControl1.SelectedTab = tabDados;
        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
              MessageBox.Show
              ("Tem certeza que deseja excluir?",
              "Pergunta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Faz a exclusão
                Dpto obj = new Dpto();
                obj.id = int.Parse(txtIdDpto.Text);

                dptoController controller = new dptoController();
                controller.excluirDpto(obj);
                dataGridView1.DataSource = controller.listarDpto();
                limparCampos();
                botaoEditar.Enabled = false;
                botaoExcluir.Enabled = false;
                tabControl1.SelectedTab = tabPesquisa;
            }
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            status = "alterando";
        }
    }
}
