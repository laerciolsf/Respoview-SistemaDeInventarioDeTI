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
    public partial class FItens : Form
    {
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

            //desabilita os botoes.
            botaoSalvar.Enabled = false;
            botaoEditar.Enabled = false;
            botaoExcluir.Enabled = false;
        }

        public void habilitarCampos()
        {
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
            txtLoja.Enabled = true;
            txtDpto.Enabled = true;

            //habilita o botão salvar.
            botaoSalvar.Enabled = true;
        }

        public void limparCampos()
        {
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

            itensController controller = new itensController();
            controller.cadastrarItens(obj);

            limparCampos();
            desabilitarCampos();
            dataGridView1.DataSource = controller.listarItens();

            // tabControl1.SelectedTab = tabPesquisa;

        }

        private void botaoNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            limparCampos();
            // status = "inserindo";
            tabControl1.SelectedTab = tabDados;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = "%" + textBox1.Text + "%";

            itensController controller = new itensController();
            dataGridView1.DataSource = controller.buscaPorNome(nome);

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum produto encontrado com este nome");
                dataGridView1.DataSource = controller.listarItens();
            }
        }
    }
}
