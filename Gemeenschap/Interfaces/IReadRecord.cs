using Gemeenschap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemeenschap.Interfaces
{
    public interface IReadRecord
    {
        Docent GetDocent(int id);
        IEnumerable<Docent> GetAllDocent();
        IEnumerable<Campus> GetAllCampus();
    }
}
