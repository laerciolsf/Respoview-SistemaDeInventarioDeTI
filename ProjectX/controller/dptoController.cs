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
    public class dptoController
    {
        private MySqlConnection conexao;

        public dptoController()
        {
            this.conexao = new conn().GetConnection();
        }

        public void cadastrarDpto(Dpto obj)
        {
            try
            {
                string sql = @"insert into departamentos
                                (departamento) values 
                                (@departamento);";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@departamento", obj.dpto);
                

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Departamento cadastrado com sucesso");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }
        public DataTable listarDpto()
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = "select * from departamentos;";

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
                string sql = "select * from departamentos where departamento like @dpto;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@dpto", nome);
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
        public void alterarDpto(Dpto obj)
        {
            try
            {
                string sql = @"update departamentos set departamento = @dpto
                                where idDepartamento = @idDpto;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@dpto", obj.dpto);
                executacmd.Parameters.AddWithValue("@idDpto", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Departamento alterado com sucesso");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar: " + ex.Message);
            }

        }
        public void excluirDpto(Dpto obj)
        {
            try
            {
                string sql = "delete from departamentos where idDepartamento = @idDpto;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@idDpto", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Departamento excluído com sucesso!");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro, talvez existam itens que ainda estão vinculados a esse departamento.");
                MessageBox.Show("Erro: " + ex.Message);
                
            }
        }
    }
}
