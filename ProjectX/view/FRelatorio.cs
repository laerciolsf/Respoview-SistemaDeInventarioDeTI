﻿using ProjectX.controller;
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
    public partial class FRelatorio : Form
    {
        public FRelatorio()
        {
            InitializeComponent();
        }

        private void FRelatorio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPesquisa1_Click(object sender, EventArgs e)
        {
            FPesquisaDpto pesquisa = new FPesquisaDpto();
            pesquisa.ShowDialog();
            txtDpto.Text = pesquisa.selecionado.id.ToString();
            labelNomeDpto.Text = pesquisa.selecionado.dpto;
        }

        private void buttonPesquisa2_Click(object sender, EventArgs e)
        {
            FPesquisaLoja pesquisa = new FPesquisaLoja();
            pesquisa.ShowDialog();
            txtLoja.Text = pesquisa.selecionado.id.ToString();
            labelNomeLoja.Text = pesquisa.selecionado.loja;
        }

        private void txtLoja_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BPesquisa_Click(object sender, EventArgs e)
        {
            string nome = txtLoja.Text;

            itensController controller = new itensController();
            dataGridView1.DataSource = controller.pesquisaRelatorios(nome);

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum item encontrado com este nome");
                //dataGridView1.DataSource = controller.listarItens();
            }
        }
    }
}