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
        public static IService GetService()
        {
            return new OpleidingenService();
        }
        public static Docent GetDocent()
        {
            return new Docent();
        }
        public static Docent GetDocent(string voornaam, string familienaam, decimal wedde, int campusNr)
        {
            return new Docent()
            {
                Voornaam = voornaam,
                Familienaam = familienaam,
                Wedde = wedde,
                CampusNr = campusNr
            };
        }
    }
}
