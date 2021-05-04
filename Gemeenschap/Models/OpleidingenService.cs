using Dapper;
using Gemeenschap.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gemeenschap.Models
{
    public class OpleidingenService : IService
    {
        private readonly ICreateConnection DbManager;
        public OpleidingenService()
        {
            DbManager = GemeenschapFactory.GetDbManager();
        }

        public void DeleteDocentRow(int id)
        {
            string sql = "DELETE FROM [Docenten] WHERE DocentNr = @DocentNr";
            using(var con = DbManager.GetConnection())
            {
                con.Query(sql, new { DocentNr = id });
            }
        }

        public IEnumerable<Campus> GetAllCampus()
        {
            string sql = "SELECT * FROM [Campussen]";
            using (var con = DbManager.GetConnection())
            {
                return con.Query<Campus>(sql);
            }
        }

        public IEnumerable<Docent> GetAllDocent()
        {
            string sql = "SELECT * FROM [Docenten]";
            using (var con = DbManager.GetConnection())
            {
                return con.Query<Docent>(sql);
            }
        }

        public Docent GetDocent(int id)
        {
            string sql = "SELECT * FROM [Docenten] WHERE DocentNr = @DocentNr";
            using (var con = DbManager.GetConnection())
            {
                return con.QuerySingle<Docent>(sql, new { DocentNr = id });
            }
        }

        public void InsertDocent(Docent obj)
        {
            string sql = "INSERT INTO [Docenten] (Voornaam, Familienaam, Wedde, CampusNr) VALUES (@Voornaam, @Familienaam, @Wedde, @CampusNr)";
            using (var con = DbManager.GetConnection())
            {
                con.Query(sql, obj);
            }
        }

        public void UpdateDocent(Docent obj)
        {
            string sql = "UPDATE [Docenten] SET Voornaam = @Voornaam, Familienaam=@Familienaam, Wedde=@Wedde, CampusNr=@CampusNr";
            using (var con = DbManager.GetConnection())
            {
                con.Query(sql, obj);
            }
        }
    }
}
