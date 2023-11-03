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
    public partial class FCamposExporta : Form
    {
        public FCamposExporta()
        {
            InitializeComponent();
        }

        private void buttonPesquisa2_Click(object sender, EventArgs e)
        {
            FPesquisaLoja pesquisa = new FPesquisaLoja();
            pesquisa.ShowDialog();
            txtLoja.Text = pesquisa.selecionado.id.ToString();
            labelNomeLoja.Text = pesquisa.selecionado.loja;
        }
        private void buttonPesquisa1_Click(object sender, EventArgs e)
        {
            FPesquisaDpto pesquisa = new FPesquisaDpto();
            pesquisa.ShowDialog();
            txtDpto.Text = pesquisa.selecionado.id.ToString();
            labelNomeDpto.Text = pesquisa.selecionado.dpto;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtDpto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoja_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
}
