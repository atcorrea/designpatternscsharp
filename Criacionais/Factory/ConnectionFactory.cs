
using System.Data;
using System.Data.SqlClient;

namespace designpattenscsharp.Criacionais.Factory
{
    public class ConnectionFactory
    {
       public IDbConnection GetConnection()
       {
           var conexao = new SqlConnection();
           conexao.ConnectionString = "User Id=root;Password=;Server=localhost;Database=banco";
           return conexao;
       } 
    }
}