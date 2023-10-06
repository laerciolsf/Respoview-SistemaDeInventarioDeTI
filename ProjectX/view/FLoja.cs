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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectX.view
{
    public partial class FLoja : Form
    {
        private string status = "";
        public FLoja()
        {
            InitializeComponent();
        }
        public void desabilitarCampos()
        {
            txtIdLoja.Enabled = false;
            txtNomeLoja.Enabled = false;

            //desabilita os botoes
            botaoSalvar.Enabled = false;
            botaoEditar.Enabled = false;
            botaoExcluir.Enabled = false;
        }

        public void habilitarCampos()
        {
            //txtId.Enabled = false;
            txtNomeLoja.Enabled = true;
            botaoSalvar.Enabled = true;
        }

        public void limparCampos()
        {
            txtIdLoja.Text = String.Empty;
            txtNomeLoja.Text = String.Empty;

            txtNomeLoja.Focus();
        }

        private void FLoja_Load(object sender, EventArgs e)
        {
            desabilitarCampos();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if para evitar o bug do botao novo
            if (status == "inserindo")
            {
                desabilitarCampos();
                status = "";
            }

            //Pegar os dados da grid para os campos
            txtIdLoja.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNomeLoja.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            //habilita os botões
            botaoEditar.Enabled = true;
            botaoExcluir.Enabled = true;
            //Vai para a aba de dados
            tabControl1.SelectedTab = tabDados;
        }

        private void tabDados_Click(object sender, EventArgs e)
        {

        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Loja obj = new Loja();

            obj.loja = txtNomeLoja.Text;

            lojaController controller = new lojaController();

            if (status == "inserindo")
            {
                controller.cadastrarLoja(obj);
                status = "";
            }
            else if (status == "alterando")
            {
                obj.id = int.Parse(txtIdLoja.Text);
                controller.alterarLoja(obj);
                status = "";

            }
            limparCampos();
            desabilitarCampos();
            dataGridView1.DataSource = controller.listarLoja();

            tabControl1.SelectedTab = tabPesquisa;

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
                Loja obj = new Loja();
                obj.id = int.Parse(txtIdLoja.Text);

                lojaController controller = new lojaController();
                controller.excluirLoja(obj);



                dataGridView1.DataSource = controller.listarLoja();
                limparCampos();
                botaoEditar.Enabled = false;
                botaoExcluir.Enabled = false;
                tabControl1.SelectedTab = tabPesquisa;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = "%" + textBox1.Text + "%";

            lojaController controller = new lojaController();
            dataGridView1.DataSource = controller.buscaPorNome(nome);

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nenhuma loja encontrado com este nome");
                dataGridView1.DataSource = controller.listarLoja();
            }
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            status = "alterando";
        }
    }
}
