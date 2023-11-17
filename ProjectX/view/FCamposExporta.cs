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
using static ProjectX.controller.itensController;

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
                    // Remova as colunas idBitLocker e chaveBitLocker do DataTable antes de exportar para PDF
                    resultado.Columns.Remove("idBitLocker");
                    resultado.Columns.Remove("chaveBitLocker");

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

        private void buttonCsv_Click(object sender, EventArgs e)
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
                    // Remova as colunas idBitLocker e chaveBitLocker do DataTable antes de exportar para CSV
                    resultado.Columns.Remove("idBitLocker");
                    resultado.Columns.Remove("chaveBitLocker");

                    string caminhoDoArquivoCSV = @"C:\Users\laerc\OneDrive\Documentos\Relatorios\relatorio.csv";

                    // Crie uma instância da classe CSVExporter e exporte os dados
                    CSVExporter csvExporter = new CSVExporter();
                    csvExporter.ExportToCSV(resultado, caminhoDoArquivoCSV);

                    MessageBox.Show("Relatório exportado para 'relatorio.csv'");
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

        private void checkBoxId_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxUserRes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxNomeEquipamento_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxQuantidade_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxTipo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxFabricante_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxModelo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxProcessador_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxMemoria_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxHdSsd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSistemOperacional_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxValorEstimado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxIdLoja_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxIdDepartamento_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
