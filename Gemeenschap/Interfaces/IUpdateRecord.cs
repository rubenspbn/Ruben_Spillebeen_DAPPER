using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemeenschap.Interfaces
{
    public interface IUpdateRecord<T>
    {
        Task UpdateAsync(T obj);
    }
}
