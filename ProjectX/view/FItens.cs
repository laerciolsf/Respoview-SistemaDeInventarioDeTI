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
    public partial class FItens : Form
    {
        public FItens()
        {
            InitializeComponent();
        }

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

        }
    }
}
