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

        public DataTable pesquisaRelatorios(string nome)
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = "select * from itens where idLoja = @idLoja;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@idLoja", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabela);

                conexao.Close();
                return tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar relatorio: " + ex.Message);
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
    }
}
