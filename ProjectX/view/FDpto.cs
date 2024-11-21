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

            // Desabilita os botões
            botaoSalvar.Enabled = false;
            botaoEditar.Enabled = false;
            botaoExcluir.Enabled = false;
        }

        public void habilitarCampos()
        {
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
            if (FMenu.usuario_logado.nivelAcesso == 3) // Usuário de nível 3 (somente leitura)
            {
                MessageBox.Show("Você não tem permissão para adicionar novos departamentos.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            habilitarCampos();
            limparCampos();
            status = "inserindo";
            tabControl1.SelectedTab = tabDados;
        }

        private void FDpto_Load(object sender, EventArgs e)
        {
            desabilitarCampos();

            // Verifica o nível de acesso do usuário logado
            if (FMenu.usuario_logado.nivelAcesso == 3) // Somente leitura
            {
                MessageBox.Show($"Bem-vindo(a), {FMenu.usuario_logado.nome}. Você está em modo somente leitura.", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            if (FMenu.usuario_logado.nivelAcesso == 3) // Usuário de nível 3
            {
                MessageBox.Show("Você não tem permissão para salvar alterações.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            if (status == "inserindo")
            {
                desabilitarCampos();
                status = "";
            }

            // Pegar os dados da grid para os campos
            txtIdDpto.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNomeDpto.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            // Verifica o nível de acesso do usuário logado
            if (FMenu.usuario_logado.nivelAcesso == 3) // Usuário de nível 3 (somente leitura)
            {
                // Não habilita botões de edição ou exclusão
                botaoEditar.Enabled = false;
                botaoExcluir.Enabled = false;
            }
            else
            {
                // Habilita os botões para outros níveis de acesso
                botaoEditar.Enabled = true;
                botaoExcluir.Enabled = true;
            }

            tabControl1.SelectedTab = tabDados;
        }


        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            if (FMenu.usuario_logado.nivelAcesso == 3) // Usuário de nível 3
            {
                MessageBox.Show("Você não tem permissão para excluir departamentos.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult =
              MessageBox.Show("Tem certeza que deseja excluir?", "Pergunta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
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
            if (FMenu.usuario_logado.nivelAcesso == 3) // Usuário de nível 3
            {
                MessageBox.Show("Você não tem permissão para editar departamentos.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            habilitarCampos();
            status = "alterando";
        }
    }
}
