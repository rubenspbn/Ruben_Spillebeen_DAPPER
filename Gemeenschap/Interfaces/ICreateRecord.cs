using Gemeenschap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemeenschap.Interfaces
{
    public interface ICreateRecord
    {
        void InsertDocent(Docent obj);
    }
}
