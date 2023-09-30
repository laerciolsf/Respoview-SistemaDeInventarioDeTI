using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX
{

    internal class Conn
    {
        public MySqlConnection GetConnection()
        {
            string conexao = "server=localhost; " +
                "user=root; password=senhaAqui; " +
                "database=mallon_bd;";

            return new MySqlConnection(conexao);
        }

    }

}

