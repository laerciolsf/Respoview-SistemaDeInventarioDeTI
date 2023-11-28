using ProjectX.controller;
using System;
using System.Windows.Forms;

namespace ProjectX.view
{
    public partial class FBitlocker : Form
    {
        public FBitlocker()
        {
            InitializeComponent();
        }

        private void FBitlocker_Load(object sender, EventArgs e)
        {
            // Alguma lógica de inicialização, se necessário
        }

        private void txtchaveBitLocker_TextChanged(object sender, EventArgs e)
        {
            // Alguma lógica adicional, se necessário
        }

        private void txtidBitLocker_TextChanged(object sender, EventArgs e)
        {
            // Alguma lógica adicional, se necessário
        }

        private string BuscarChave(string identificador)
        {
            try
            {
                // Cria uma instância do itensController e chama o método para buscar a chave
                return new itensController().BuscarChavePorIdentificador(identificador);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar chave: {ex.Message}");
                return null;
            }
        }

        private async void BPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                // Desabilitar o botão de pesquisa para evitar múltiplos cliques enquanto a busca está em andamento
                BPesquisa.Enabled = false;

                string identificadorStr = txtidBitLocker.Text.Trim();

                if (!string.IsNullOrEmpty(identificadorStr))
                {
                    // Chama o método que busca a chave com base no identificador
                    string chave = await Task.Run(() => BuscarChave(identificadorStr));

                    // Exibe a chave (ou trate caso não encontre)
                    if (!string.IsNullOrEmpty(chave))
                    {
                        txtchaveBitLocker.Text = chave;
                    }
                    else
                    {
                        MessageBox.Show("Chave não encontrada para o identificador fornecido.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um identificador válido.");
                }
            }
            catch (Exception ex)
            {
                // Log ou trate a exceção conforme necessário
                Console.WriteLine($"Erro na pesquisa: {ex.Message}");
            }
            finally
            {
                // Reabilitar o botão de pesquisa, independentemente do resultado
                BPesquisa.Enabled = true;
            }
        }
    }
}
