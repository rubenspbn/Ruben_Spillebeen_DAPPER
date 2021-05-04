using Gemeenschap.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
