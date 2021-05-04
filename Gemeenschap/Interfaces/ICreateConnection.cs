using System.Data;

namespace Gemeenschap.Interfaces
{
    public interface ICreateConnection
    {
        IDbConnection GetConnection();
    }
}
