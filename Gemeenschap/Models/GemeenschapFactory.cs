using Gemeenschap.Interfaces;

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
        public static Docent GetDocent(int docentNr, string voornaam, string familienaam, decimal wedde, int campusNr)
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
