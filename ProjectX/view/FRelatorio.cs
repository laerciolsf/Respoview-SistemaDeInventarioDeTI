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
using static ProjectX.controller.itensController;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
            int idLoja = 0;
            int idDepartamento = 0;

            if (int.TryParse(txtLoja.Text, out idLoja))
            {
                if (!string.IsNullOrEmpty(txtDpto.Text) && !int.TryParse(txtDpto.Text, out idDepartamento))
                {
                    MessageBox.Show("Informe um ID de departamento válido ou deixe o campo em branco.");
                    return;
                }

                itensController controller = new itensController();
                dataGridView1.DataSource = controller.pesquisaRelatorios(idLoja, idDepartamento);

                // Ocultar as colunas idBitLocker e chaveBitLocker
                dataGridView1.Columns["idBitLocker"].Visible = false;
                dataGridView1.Columns["chaveBitLocker"].Visible = false;

                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum item encontrado com este ID de loja e/ou departamento.");
                }
            }
            else
            {
                MessageBox.Show("Informe um ID de loja válido.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FCamposExporta tela = new FCamposExporta();
            tela.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


