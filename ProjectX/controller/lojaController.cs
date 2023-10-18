using MySql.Data.MySqlClient;
using ProjectX.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.controller
{
    internal class lojaController
    {
        private MySqlConnection conexao;

        public lojaController()
        {
            this.conexao = new conn().GetConnection();
        }

        public void cadastrarLoja(Loja obj)
        {
            try
            {
                string sql = @"insert into lojas
                                (loja) values 
                                (@loja);";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@loja", obj.loja);


                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Loja cadastrado com sucesso");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }

        }
        public DataTable listarLoja()
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = "select * from lojas;";

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
        public DataTable buscaPorNome(string nome)
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = "select * from lojas where loja like @loja;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@loja", nome);
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
        public void alterarLoja(Loja obj)
        {
            try
            {
                string sql = @"update lojas set loja = @loja
                                where idLoja = @idLoja;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@loja", obj.loja);
                executacmd.Parameters.AddWithValue("@idLoja", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Loja alterada com sucesso");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar: " + ex.Message);
            }

        }
        public void excluirLoja(Loja obj)
        {
            try
            {
                string sql = "delete from lojas where idLoja = @idLoja;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@idLoja", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Loja excluído com sucesso!");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro, talvez existam itens que ainda estão vinculados a essa loja.");
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}

