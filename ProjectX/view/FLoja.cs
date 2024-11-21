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

            // Desabilita os botões
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

            // Verifica o nível de acesso do usuário logado
            if (FMenu.usuario_logado.nivelAcesso == 3) // Somente leitura
            {
                MessageBox.Show($"Bem-vindo(a), {FMenu.usuario_logado.nome}. Você está em modo somente leitura.",
                    "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Desabilita os botões que permitem alterações
                botaoNovo.Enabled = false;
                botaoEditar.Enabled = false;
                botaoExcluir.Enabled = false;

                // Desabilita a edição no DataGridView
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoNovo_Click(object sender, EventArgs e)
        {
            if (FMenu.usuario_logado.nivelAcesso == 3) // Usuário de nível 3 (somente leitura)
            {
                MessageBox.Show("Você não tem permissão para adicionar novas lojas.",
                    "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            habilitarCampos();
            limparCampos();
            status = "inserindo";
            tabControl1.SelectedTab = tabDados;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar bug do botão novo
            if (status == "inserindo")
            {
                desabilitarCampos();
                status = "";
            }

            // Pegar os dados da grid para os campos
            txtIdLoja.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNomeLoja.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            // Verifica o nível de acesso do usuário logado
            if (FMenu.usuario_logado.nivelAcesso == 3) // Usuário de nível 3 (somente leitura)
            {
                botaoEditar.Enabled = false;
                botaoExcluir.Enabled = false;
            }
            else
            {
                botaoEditar.Enabled = true;
                botaoExcluir.Enabled = true;
            }

            tabControl1.SelectedTab = tabDados;
        }

        private void tabDados_Click(object sender, EventArgs e)
        {
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            if (FMenu.usuario_logado.nivelAcesso == 3) // Usuário de nível 3
            {
                MessageBox.Show("Você não tem permissão para salvar alterações.",
                    "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            if (FMenu.usuario_logado.nivelAcesso == 3) // Usuário de nível 3
            {
                MessageBox.Show("Você não tem permissão para excluir lojas.",
                    "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult =
                MessageBox.Show("Tem certeza que deseja excluir?", "Pergunta", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
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
                MessageBox.Show("Nenhuma loja encontrada com este nome.");
                dataGridView1.DataSource = controller.listarLoja();
            }
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            if (FMenu.usuario_logado.nivelAcesso == 3) // Usuário de nível 3
            {
                MessageBox.Show("Você não tem permissão para editar lojas.",
                    "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            habilitarCampos();
            status = "alterando";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
