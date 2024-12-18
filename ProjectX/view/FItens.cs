﻿using ProjectX.controller;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectX.view
{

    public partial class FItens : Form
    {
        private string status = "";
        public FItens()
        {
            InitializeComponent();
        }

        public void desabilitarCampos()
        {
            txtId.Enabled = false;
            txtUsuarioResponsavel.Enabled = false;
            txtNome.Enabled = false;
            txtQtde.Enabled = false;
            txtTipo.Enabled = false;
            txtFabricante.Enabled = false;
            txtModelo.Enabled = false;
            txtProcessador.Enabled = false;
            txtMemoria.Enabled = false;
            txtHd.Enabled = false;
            txtSo.Enabled = false;
            txtValor.Enabled = false;
            txtLoja.Enabled = false;
            txtDpto.Enabled = false;
            txtchaveBitLocker.Enabled = false;
            txtidBitLocker.Enabled = false;

            //desabilita os botoes.
            botaoSalvar.Enabled = false;
            botaoEditar.Enabled = false;
            botaoExcluir.Enabled = false;
            buttonPesquisa1.Enabled = false;
            buttonPesquisa2.Enabled = false;

        }

        public void habilitarCampos()
        {
            txtId.Enabled = true;
            txtId.Enabled = false;
            txtUsuarioResponsavel.Enabled = true;
            txtNome.Enabled = true;
            txtQtde.Enabled = true;
            txtTipo.Enabled = true;
            txtFabricante.Enabled = true;
            txtModelo.Enabled = true;
            txtProcessador.Enabled = true;
            txtMemoria.Enabled = true;
            txtHd.Enabled = true;
            txtSo.Enabled = true;
            txtValor.Enabled = true;
            txtLoja.Enabled = false;
            txtDpto.Enabled = false;
            txtchaveBitLocker.Enabled = true;
            txtidBitLocker.Enabled = true;

            //habilita o botão salvar.
            botaoSalvar.Enabled = true;
            buttonPesquisa1.Enabled = true;
            buttonPesquisa2.Enabled = true;
        }

        public void limparCampos()
        {
            txtId.Text = String.Empty;
            txtUsuarioResponsavel.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtQtde.Text = String.Empty;
            txtTipo.Text = String.Empty;
            txtFabricante.Text = String.Empty;
            txtModelo.Text = String.Empty;
            txtProcessador.Text = String.Empty;
            txtMemoria.Text = String.Empty;
            txtHd.Text = String.Empty;
            txtSo.Text = String.Empty;
            txtValor.Text = String.Empty;
            txtLoja.Text = String.Empty;
            txtDpto.Text = String.Empty;
            txtchaveBitLocker.Text = String.Empty;
            txtidBitLocker.Text = String.Empty;


            //Trava o cursor no segundo campo.
            txtUsuarioResponsavel.Focus();
        }
        //testandoi


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Itens obj = new Itens();

            obj.usuarioResponsavel = txtUsuarioResponsavel.Text;
            obj.nomeEquipamento = txtNome.Text;
            obj.quantidade = txtQtde.Text;
            obj.tipo = txtTipo.Text;
            obj.fabricante = txtFabricante.Text;
            obj.modelo = txtModelo.Text;
            obj.processador = txtProcessador.Text;
            obj.memoria = txtMemoria.Text;
            obj.hd_ssd = txtHd.Text;
            obj.sistemaOperacional = txtSo.Text;
            obj.valorEstimado = float.Parse(txtValor.Text);
            obj.idLoja = int.Parse(txtLoja.Text);
            obj.idDepartamento = int.Parse(txtDpto.Text);
            obj.chaveBitLocker = txtchaveBitLocker.Text;
            obj.idBitLocker = txtidBitLocker.Text;

            itensController controller = new itensController();

            if (status == "inserindo")
            {
                controller.cadastrarItens(obj);
                status = "";
            }
            else if (status == "alterando")
            {
                obj.id = int.Parse(txtId.Text);
                controller.alterarItens(obj);
                status = "";

            }
            limparCampos();
            desabilitarCampos();
            dataGridView1.DataSource = controller.listarItens();

            tabControl1.SelectedTab = tabPesquisa;

        }
        private void botaoNovo_Click(object sender, EventArgs e)
        {
            if (FMenu.usuario_logado.nivelAcesso == 3) // Usuário de nível 3 (somente leitura)
            {
                MessageBox.Show("Você não tem permissão para adicionar novos itens.",
                    "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            habilitarCampos();
            limparCampos();
            status = "inserindo";
            tabControl1.SelectedTab = tabDados;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = "%" + textBox1.Text + "%";

            itensController controller = new itensController();
            dataGridView1.DataSource = controller.buscaPorNome(nome);

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum item encontrado com este nome");
                dataGridView1.DataSource = controller.listarItens();
            }
        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FItens_Load(object sender, EventArgs e)
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

                // Caso necessário, desabilite outros controles específicos
                buttonPesquisa1.Enabled = false;
                buttonPesquisa2.Enabled = false;
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
            if (dataGridView1.CurrentRow != null)
            {
                txtId.Text = dataGridView1.CurrentRow.Cells[0].Value?.ToString() ?? string.Empty;
                txtUsuarioResponsavel.Text = dataGridView1.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;
                txtNome.Text = dataGridView1.CurrentRow.Cells[2].Value?.ToString() ?? string.Empty;
                txtQtde.Text = dataGridView1.CurrentRow.Cells[3].Value?.ToString() ?? string.Empty;
                txtTipo.Text = dataGridView1.CurrentRow.Cells[4].Value?.ToString() ?? string.Empty;
                txtFabricante.Text = dataGridView1.CurrentRow.Cells[5].Value?.ToString() ?? string.Empty;
                txtModelo.Text = dataGridView1.CurrentRow.Cells[6].Value?.ToString() ?? string.Empty;
                txtProcessador.Text = dataGridView1.CurrentRow.Cells[7].Value?.ToString() ?? string.Empty;
                txtMemoria.Text = dataGridView1.CurrentRow.Cells[8].Value?.ToString() ?? string.Empty;
                txtHd.Text = dataGridView1.CurrentRow.Cells[9].Value?.ToString() ?? string.Empty;
                txtSo.Text = dataGridView1.CurrentRow.Cells[10].Value?.ToString() ?? string.Empty;
                txtValor.Text = dataGridView1.CurrentRow.Cells[11].Value?.ToString() ?? string.Empty;
                txtLoja.Text = dataGridView1.CurrentRow.Cells[12].Value?.ToString() ?? string.Empty;
                txtDpto.Text = dataGridView1.CurrentRow.Cells[13].Value?.ToString() ?? string.Empty;
                txtchaveBitLocker.Text = dataGridView1.CurrentRow.Cells[14].Value?.ToString() ?? string.Empty;
                txtidBitLocker.Text = dataGridView1.CurrentRow.Cells[15].Value?.ToString() ?? string.Empty;

                // Habilita/desabilita botões com base no nível de acesso
                if (FMenu.usuario_logado.nivelAcesso == 3) // Nível 3: Somente leitura
                {
                    botaoEditar.Enabled = false;
                    botaoExcluir.Enabled = false;
                }
                else
                {
                    botaoEditar.Enabled = true;
                    botaoExcluir.Enabled = true;
                }

                // Define a aba de dados como ativa
                tabControl1.SelectedTab = tabDados;
            }
        }


        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            if (FMenu.usuario_logado.nivelAcesso == 3) // Usuário de nível 3
            {
                MessageBox.Show("Você não tem permissão para excluir itens.",
                    "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult =
                MessageBox.Show("Tem certeza que deseja excluir?", "Pergunta", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Itens obj = new Itens();
                obj.id = int.Parse(txtId.Text);

                itensController controller = new itensController();
                controller.excluirItens(obj);

                dataGridView1.DataSource = controller.listarItens();
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
                MessageBox.Show("Você não tem permissão para editar itens.",
                    "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            habilitarCampos();
            status = "alterando";
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tabDados_Click(object sender, EventArgs e)
        {

        }

        private void buttonPesquisa2_Click(object sender, EventArgs e)
        {

        }

        private void txtDpto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPesquisa2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonPesquisa1_Click(object sender, EventArgs e)
        {
            FPesquisaDpto pesquisa = new FPesquisaDpto();
            pesquisa.ShowDialog();
            txtDpto.Text = pesquisa.selecionado.id.ToString();
            labelNomeDpto.Text = pesquisa.selecionado.dpto;
        }

        private void buttonPesquisa2_Click_2(object sender, EventArgs e)
        {
            FPesquisaLoja pesquisa = new FPesquisaLoja();
            pesquisa.ShowDialog();
            txtLoja.Text = pesquisa.selecionado.id.ToString();
            labelNomeLoja.Text = pesquisa.selecionado.loja;
        }

        private void txtidBitLocker_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
