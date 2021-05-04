using Gemeenschap.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemeenschap.Models
{
    public static class GemeenschapFactory
    {
        public static ICreateConnection GetDbManager()
        {
            return new OpleidingDbManager();
        }
    }
}
