using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemeenschap.Interfaces
{
    public interface IDeleteRecord
    {
        Task DeleteRowAsync(int id);
    }
}
