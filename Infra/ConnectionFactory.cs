using System.Configuration;
using System.Data.SqlClient;

namespace Livraria.Infra
{
    public class ConnectionFactory
    {
        public static SqlConnection CriaConexaoAberta()
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["livraria"].ConnectionString;
            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();
            return conexao;
        }
    }
}