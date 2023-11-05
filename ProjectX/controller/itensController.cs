using ProjectX.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Reflection;
using System.Data;
using System.Reflection.Metadata;
using PdfSharpCore.Pdf;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf.IO;
using PdfSharpCore;

namespace ProjectX.controller
{
    public class itensController
    {
        private MySqlConnection conexao;
        public itensController()
        {
            this.conexao = new conn().GetConnection();
        }
        public void cadastrarItens(Itens obj)
        {
            try
            {
                string sql = @"insert into itens 
                                (usuarioResponsavel,nomeEquipamento,quantidade,tipo,fabricante,
                                modelo,processador,memoria,hd_ssd,sistemaOperacional,valorEstimado,
                                idLoja,idDepartamento) values 
                                (@usuarioResponsavel,@nomeEquipamento,@quantidade,@tipo,@fabricante,
                                @modelo,@processador,@memoria,@hd_ssd,@sistemaOperacional,@valorEstimado,
                                @idLoja,@idDepartamento);";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@usuarioResponsavel", obj.usuarioResponsavel);
                executacmd.Parameters.AddWithValue("@nomeEquipamento", obj.nomeEquipamento);
                executacmd.Parameters.AddWithValue("@quantidade", obj.quantidade);
                executacmd.Parameters.AddWithValue("@tipo", obj.tipo);
                executacmd.Parameters.AddWithValue("@fabricante", obj.fabricante);
                executacmd.Parameters.AddWithValue("@modelo", obj.modelo);
                executacmd.Parameters.AddWithValue("@processador", obj.processador);
                executacmd.Parameters.AddWithValue("@memoria", obj.memoria);
                executacmd.Parameters.AddWithValue("@hd_ssd", obj.hd_ssd);
                executacmd.Parameters.AddWithValue("@sistemaOperacional", obj.sistemaOperacional);
                executacmd.Parameters.AddWithValue("@valorEstimado", obj.valorEstimado);
                executacmd.Parameters.AddWithValue("@idLoja", obj.idLoja);
                executacmd.Parameters.AddWithValue("@idDepartamento", obj.idDepartamento);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Item cadastrado com sucesso");
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }
        public DataTable listarItens()
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = "select * from itens;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabela);

                conexao.Close();
                return tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
                return null;
            }
        }

        public DataTable pesquisaRelatorios(int idLoja, int idDepartamento)
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = "SELECT * FROM itens WHERE idLoja = @idLoja";

                if (idDepartamento > 0)
                {
                    sql += " AND idDepartamento = @idDepartamento";
                }

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@idLoja", idLoja);

                if (idDepartamento > 0)
                {
                    executacmd.Parameters.AddWithValue("@idDepartamento", idDepartamento);
                }

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabela);

                conexao.Close();
                return tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar relatório: " + ex.Message);
                return null;
            }
        }


        public DataTable buscaPorNome(string nome)
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = "select * from itens where nomeEquipamento like @nomeEquipamento;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nomeEquipamento", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabela);

                conexao.Close();
                return tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
                return null;
            }

        }
        public void alterarItens(Itens obj)
        {
            try
            {
                string sql = @"update itens set
                               usuarioResponsavel = @usuarioResponsavel,
                               nomeEquipamento = @nomeEquipamento,
                               quantidade = @quantidade,
                               tipo = @tipo,
                               fabricante = @fabricante,
                               modelo = @modelo,
                               processador = @processador,
                               memoria = @memoria,
                               hd_ssd = @hd_ssd,
                               sistemaOperacional = @sistemaOperacional,
                               valorEstimado = @valorEstimado,
                               idLoja = @idLoja,
                               idDepartamento = @idDepartamento
                               where id = @id;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@usuarioResponsavel", obj.usuarioResponsavel);
                executacmd.Parameters.AddWithValue("@nomeEquipamento", obj.nomeEquipamento);
                executacmd.Parameters.AddWithValue("@quantidade", obj.quantidade);
                executacmd.Parameters.AddWithValue("@tipo", obj.tipo);
                executacmd.Parameters.AddWithValue("@fabricante", obj.fabricante);
                executacmd.Parameters.AddWithValue("@modelo", obj.modelo);
                executacmd.Parameters.AddWithValue("@processador", obj.processador);
                executacmd.Parameters.AddWithValue("@memoria", obj.memoria);
                executacmd.Parameters.AddWithValue("@hd_ssd", obj.hd_ssd);
                executacmd.Parameters.AddWithValue("@sistemaOperacional", obj.sistemaOperacional);
                executacmd.Parameters.AddWithValue("@valorEstimado", obj.valorEstimado);
                executacmd.Parameters.AddWithValue("@idLoja", obj.idLoja);
                executacmd.Parameters.AddWithValue("@idDepartamento", obj.idDepartamento);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Iten alterado com sucesso");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar: " + ex.Message);
            }

        }
        public void excluirItens(Itens obj)
        {
            try
            {
                string sql = "delete from itens where id = @id;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Item excluído com sucesso!");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu um erro: " + ex.Message);
            }
        }
        public void ExportarParaPDF(DataTable dados, string caminhoDoArquivo)
        {
            // Crie um documento PDF
            PdfDocument document = new PdfDocument();

            // Defina a orientação da página para paisagem
            PdfPage page = document.AddPage();
            page.Orientation = PageOrientation.Landscape;  // Mude para paisagem
            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont font = new XFont("Arial", 6, XFontStyle.Regular);

            double x = 20; // Posição inicial horizontal
            double y = 20; // Posição inicial vertical

            // Defina as larguras das colunas individualmente
            Dictionary<string, double> columnWidths = new Dictionary<string, double>
    {
        { "id", 28 },
        { "usuarioResponsavel", 100 },
        { "nomeEquipamento", 90 },
        { "tipo", 55 },
        { "quantidade", 33 },
        { "fabricante", 55 },
        { "modelo", 60 },
        { "processador", 55 },
        { "memoria", 50 },
        { "hd_ssd", 75 },
        { "sistemaOperacional", 80 },
        { "valorEstimado", 42 },
        { "idLoja", 28 },
        { "idDepartamento", 46 }
    };

            // Adicione o cabeçalho da tabela
            foreach (DataColumn column in dados.Columns)
            {
                double columnWidth = columnWidths.ContainsKey(column.ColumnName) ? columnWidths[column.ColumnName] : 55;

                // Calcule a posição vertical central
                double centerY = y + 3;

                // Desenhe o nome da coluna no PDF com uma borda
                gfx.DrawString(column.ColumnName, font, XBrushes.Black, new XRect(x, centerY, columnWidth, 20), XStringFormats.Center);
                gfx.DrawRectangle(XPens.Black, x, y, columnWidth, 20); // Adicione uma borda à célula
                x += columnWidth; // Atualize a posição horizontal para a próxima coluna
            }

            y += 20; // Atualize a posição vertical para os dados

            // Adicione os dados da tabela
            for (int i = 0; i < dados.Rows.Count; i++)
            {
                x = 20; // Reinicie a posição horizontal para a primeira coluna
                foreach (DataColumn column in dados.Columns)
                {
                    double columnWidth = columnWidths.ContainsKey(column.ColumnName) ? columnWidths[column.ColumnName] : 55;

                    // Calcule a posição vertical central
                    double centerY = y + 3;

                    // Desenhe o valor dos dados no PDF com uma borda
                    gfx.DrawString(dados.Rows[i][column].ToString(), font, XBrushes.Black, new XRect(x, centerY, columnWidth, 20), XStringFormats.Center);
                    gfx.DrawRectangle(XPens.Black, x, y, columnWidth, 20); // Adicione uma borda à célula
                    x += columnWidth; // Atualize a posição horizontal para a próxima coluna
                }
                y += 20; // Atualize a posição vertical para a próxima linha de dados
            }
            document.Save(caminhoDoArquivo); // Salve o documento PDF no caminho especificado
        }
    }
}
