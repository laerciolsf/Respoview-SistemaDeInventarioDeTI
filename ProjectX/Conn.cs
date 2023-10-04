using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjectX
{

    public class conn
    {
        public MySqlConnection GetConnection()
        {
            string conexao = "server=localhost; " +
                             "user=root; password=familia; " +
                             "database=mallon_bd;";

            return new MySqlConnection(conexao);
        }

    }

}

