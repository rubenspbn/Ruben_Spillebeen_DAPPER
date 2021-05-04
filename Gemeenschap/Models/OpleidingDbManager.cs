using Gemeenschap.Interfaces;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Gemeenschap.Models
{
    public class OpleidingDbManager : ICreateConnection
    {
        private string Constr(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        private SqlConnection SqlConnection()
        {
            return new SqlConnection(Constr("Opleidingen"));
        }
        public IDbConnection GetConnection()
        {
            var connection = SqlConnection();
            connection.Open();
            return connection;
        }
    }
}
