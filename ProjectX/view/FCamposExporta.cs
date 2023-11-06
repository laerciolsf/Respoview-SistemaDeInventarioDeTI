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
using iTextSharp.text;
using iTextSharp.text.pdf;

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
            //id
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //usuarioResponsavel
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //nomeEquipamento
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //quantidade
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //tipo
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            //fabricante
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            //modelo
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            //processador
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            //memoria
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            //hd_ssd
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            //sistemaOperacional
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            //valorEstimado
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            //idLoja
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            //idDepartamento
        }

        private void txtDpto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoja_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BComfirmar_Click(object sender, EventArgs e)
        {
            int idLoja = 0;
            int idDepartamento = 0;

            if (int.TryParse(txtLoja.Text, out idLoja) && idLoja > 0)
            {
                if (!string.IsNullOrEmpty(txtDpto.Text) && int.TryParse(txtDpto.Text, out idDepartamento) && idDepartamento <= 0)
                {
                    MessageBox.Show("Informe um ID de departamento válido ou deixe o campo em branco.");
                    return;
                }

                itensController controller = new itensController();
                DataTable resultado = controller.pesquisaRelatorios(idLoja, idDepartamento);

                if (resultado.Rows.Count > 0)
                {
                    string caminhoDoArquivo = @"C:\Users\laerc\OneDrive\Documentos\Relatorios\relatorio.pdf"; // Defina o caminho desejado aqui
                    controller.ExportarParaPDF(resultado, caminhoDoArquivo);
                    MessageBox.Show("Relatório exportado para 'relatorio.pdf'");
                }
                else
                {
                    MessageBox.Show("Nenhum item encontrado com este ID de loja e/ou departamento.");
                }
            }
            else
            {
                MessageBox.Show("Informe um ID de loja válido.");
            }
        }
    }
}