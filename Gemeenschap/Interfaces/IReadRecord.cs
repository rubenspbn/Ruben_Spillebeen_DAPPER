using Gemeenschap.Models;
using System.Collections.Generic;

namespace Gemeenschap.Interfaces
{
    public interface IReadRecord
    {
        Docent GetDocent(int id);
        IEnumerable<Docent> GetAllDocent();
        IEnumerable<Campus> GetAllCampus();
    }
}
