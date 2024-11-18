using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.controller
{
    public class ItensRemovidosController
    {
        private MySqlConnection conexao;

        public ItensRemovidosController()
        {
            this.conexao = new conn().GetConnection();
        }


        public DataTable listarItensRemovidos()
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = "select * from log_exclusoes;";

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
    }
}
