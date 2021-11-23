using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaGestao.Base_de_dados
{
    class Conexao
    {

        SqlConnection conexao = new SqlConnection();


        public Conexao()
        {
            conexao.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\Users\felip\source\repos\SistemaGestao2\bd_SistemaGeatao.mdf;Integrated Security=True";
        }
        public SqlConnection Conectar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }

            return conexao;
        }
        public void desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
       
    }
}
