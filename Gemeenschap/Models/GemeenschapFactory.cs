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
        public static IService<Docent> GetDocentService()
        {
            return new OpleidingenService<Docent>("Docenten");
        }
        public static IService<Campus> GetCampusService()
        {
            return new OpleidingenService<Campus>("Campussen");
        }
        public static Docent GetDocent()
        {
            return new Docent();
        }
        public static Docent GetDocent(int docentNr,string voornaam, string familienaam, decimal wedde, int campusNr)
        {
            return new Docent()
            {
                DocentNr = docentNr,
                Voornaam = voornaam,
                Familienaam = familienaam,
                Wedde = wedde,
                CampusNr = campusNr
            };
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
