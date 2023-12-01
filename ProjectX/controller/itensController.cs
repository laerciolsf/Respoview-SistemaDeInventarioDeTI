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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

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
                                idLoja,idDepartamento,idBitLocker,chaveBitLocker) values 
                                (@usuarioResponsavel,@nomeEquipamento,@quantidade,@tipo,@fabricante,
                                @modelo,@processador,@memoria,@hd_ssd,@sistemaOperacional,@valorEstimado,
                                @idLoja,@idDepartamento,@idBitLocker,@chaveBitLocker);";

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
                executacmd.Parameters.AddWithValue("@idBitLocker", obj.idBitLocker);
                executacmd.Parameters.AddWithValue("@chaveBitLocker", obj.chaveBitLocker);


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


        // Método para buscar registros na tabela 'itens' com base em um valor de pesquisa no nome ou outros campos
        public DataTable buscaPorNome(string nome)
        {
            try
            {
                // Cria uma nova tabela para armazenar os resultados da consulta
                DataTable tabela = new DataTable();

                // Definição da consulta SQL parametrizada usando o comando SELECT
                string sql = "SELECT * FROM itens WHERE " +
                             "nomeEquipamento LIKE @valorPesquisa " +
                             "OR usuarioResponsavel LIKE @valorPesquisa " +
                             "OR tipo LIKE @valorPesquisa " +
                             "OR fabricante LIKE @valorPesquisa " +
                             "OR modelo LIKE @valorPesquisa " +
                             "OR CAST(id AS CHAR) LIKE @valorPesquisa;";

                // Cria um novo comando MySQL parametrizado
                using (MySqlCommand executacmd = new MySqlCommand(sql, conexao))
                {
                    // Adiciona um parâmetro para o valor de pesquisa, usando '%' para corresponder a qualquer parte do texto
                    executacmd.Parameters.AddWithValue("@valorPesquisa", "%" + nome + "%");

                    // Abre a conexão com o banco de dados
                    conexao.Open();

                    // Cria um adaptador MySQL para preencher a tabela com os resultados da consulta
                    using (MySqlDataAdapter da = new MySqlDataAdapter(executacmd))
                    {
                        // Preenche a tabela com os resultados da consulta
                        da.Fill(tabela);
                    }
                }

                // Retorna a tabela resultante da consulta
                return tabela;
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro em caso de exceção
                MessageBox.Show("Erro ao consultar: " + ex.Message);

                // Retorna nulo em caso de erro
                return null;
            }
            finally
            {
                // Garante que a conexão é fechada mesmo em caso de exceção
                conexao.Close();
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

                               idBitLocker = @idBitLocker,
                               chaveBitLocker = @chaveBitLocker,

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
                executacmd.Parameters.AddWithValue("@chaveBitLocker", obj.chaveBitLocker);
                executacmd.Parameters.AddWithValue("@idBitLocker", obj.idBitLocker);

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

        public string BuscarChavePorIdentificador(string identificador)
        {
            try
            {
                using (MySqlCommand executacmd = new MySqlCommand("SELECT chaveBitLocker FROM itens WHERE idBitLocker = @identificador;", conexao))
                {
                    executacmd.Parameters.AddWithValue("@identificador", identificador);

                    conexao.Open();
                    object resultado = executacmd.ExecuteScalar();

                    // Verifica se o resultado não é nulo antes de chamar ToString()
                    string chave = resultado != null ? resultado.ToString() : null;
                    return chave;
                }
            }
            catch (Exception ex)
            {
                // Registre a exceção em um log (ex: log4net, NLog) e, opcionalmente, relance a exceção
                Console.WriteLine("Erro ao buscar chave: " + ex.Message);
                throw;
            }
            finally
            {
                conexao.Close(); // Certifique-se de fechar a conexão mesmo se ocorrer uma exceção
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

        public class CSVExporter
        {
            public void ExportToCSV(DataTable data, string filePath, string separator = ";")
            {
                if (data == null)
                {
                    throw new ArgumentNullException("data", "DataTable não pode ser nulo.");
                }

                if (string.IsNullOrEmpty(filePath))
                {
                    throw new ArgumentNullException("filePath", "Caminho do arquivo CSV não pode ser vazio.");
                }

                // Gera um nome de arquivo alternativo se o arquivo já existir
                string filePathAlternativo = GerarNomeAlternativo(filePath, "csv");

                using (StreamWriter sw = new StreamWriter(filePathAlternativo))
                {
                    // Escreve o cabeçalho com os nomes das colunas
                    for (int i = 0; i < data.Columns.Count; i++)
                    {
                        sw.Write(data.Columns[i].ColumnName);
                        if (i < data.Columns.Count - 1)
                        {
                            sw.Write(separator);
                        }
                    }
                    sw.WriteLine();

                    // Escreve os dados
                    foreach (DataRow row in data.Rows)
                    {
                        for (int i = 0; i < data.Columns.Count; i++)
                        {
                            sw.Write(FormatCSVField(row[i], separator));
                            if (i < data.Columns.Count - 1)
                            {
                                sw.Write(separator);
                            }
                        }
                        sw.WriteLine();
                    }
                }
            }

            private string GerarNomeAlternativo(string filePath, string extensao)
            {
                string diretorio = Path.GetDirectoryName(filePath);
                string nomeArquivo = Path.GetFileNameWithoutExtension(filePath);

                int numero = 1;
                string filePathAlternativo = Path.Combine(diretorio, $"{nomeArquivo}_{numero}.{extensao}");

                // Verifica se o arquivo com o nome alternativo já existe
                while (File.Exists(filePathAlternativo))
                {
                    numero++;
                    filePathAlternativo = Path.Combine(diretorio, $"{nomeArquivo}_{numero}.{extensao}");
                }

                return filePathAlternativo;
            }

            private string FormatCSVField(object field, string separator)
            {
                if (field == null)
                {
                    return "";
                }

                string fieldStr = field.ToString();
                if (fieldStr.Contains(separator) || fieldStr.Contains("\"") || fieldStr.Contains("\n") || fieldStr.Contains("\r"))
                {
                    fieldStr = fieldStr.Replace("\"", "\"\"");
                    fieldStr = "\"" + fieldStr + "\"";
                }

                return fieldStr;
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

            // Remova as colunas que não devem ser exibidas
            string[] colunasExcluidas = { "idBitLocker", "chaveBitLocker" };
            foreach (var colunaExcluida in colunasExcluidas)
            {
                if (columnWidths.ContainsKey(colunaExcluida))
                {
                    columnWidths.Remove(colunaExcluida);
                }
            }

            // Adicione o cabeçalho da tabela (excluindo as colunas removidas)
            foreach (DataColumn column in dados.Columns)
            {
                if (columnWidths.ContainsKey(column.ColumnName))
                {
                    double columnWidth = columnWidths[column.ColumnName];

                    // Calcule a posição vertical central
                    double centerY = y + 3;

                    // Desenhe o nome da coluna no PDF com uma borda
                    gfx.DrawString(column.ColumnName, font, XBrushes.Black, new XRect(x, centerY, columnWidth, 20), XStringFormats.Center);
                    gfx.DrawRectangle(XPens.Black, x, y, columnWidth, 20); // Adicione uma borda à célula
                    x += columnWidth; // Atualize a posição horizontal para a próxima coluna
                }
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

            // Gere um nome de arquivo alternativo se o arquivo já existir
            string caminhoAlternativo = GerarNomeAlternativo(caminhoDoArquivo);

            // Salve o documento PDF no caminho especificado ou no caminho alternativo gerado
            document.Save(caminhoAlternativo);
        }

        private string GerarNomeAlternativo(string caminhoDoArquivo)
        {
            string diretorio = Path.GetDirectoryName(caminhoDoArquivo);
            string nomeArquivo = Path.GetFileNameWithoutExtension(caminhoDoArquivo);
            string extensao = Path.GetExtension(caminhoDoArquivo);

            int numero = 1;
            string caminhoAlternativo = Path.Combine(diretorio, $"{nomeArquivo}_{numero}{extensao}");

            // Verifique se o arquivo com o nome alternativo já existe
            while (File.Exists(caminhoAlternativo))
            {
                numero++;
                caminhoAlternativo = Path.Combine(diretorio, $"{nomeArquivo}_{numero}{extensao}");
            }

            return caminhoAlternativo;
        }

    }
}

