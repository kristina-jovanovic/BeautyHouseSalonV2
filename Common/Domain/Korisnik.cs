using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Korisnik : IEntity
    {
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string KodZaEnkripciju { get; set; }
        public bool Vlasnik { get; set; } = false;
        public string TableName => "Korisnik";

        public string Values => $"'{Ime}', '{Prezime}', '{DatumRodjenja.ToString("yyyyMMdd")}', '{BrojTelefona}', '{Email}', '{KorisnickoIme}', " +
            $"'{Lozinka}', '{KodZaEnkripciju}', {(Vlasnik ? 1 : 0)}";

        public string PrimaryKey => KorisnikID.ToString();

        //public string GetById => $"KorisnickoIme='{KorisnickoIme}' AND Lozinka='{Lozinka}'";
        public string GetById => $"KorisnickoIme='{KorisnickoIme}'";

        public string JoinQuery => "";

        public string UpdateQuery => throw new NotImplementedException();

        public string Aliaces => "";

        public string FilterQuery(string filter)
        {
            throw new NotImplementedException();
        }

        public string FilterQueryStatus(StatusZahteva status)
        {
            throw new NotImplementedException();
        }

        public Task<List<IEntity>> GetReaderListAsync(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public async Task<IEntity> GetReaderResultAsync(SqlDataReader reader)
        {
            if (await reader.ReadAsync())
            {
                Korisnik korisnik = new Korisnik();
                korisnik.KorisnikID = (int)reader["KorisnikID"];
                korisnik.Ime = (string)reader["Ime"];
                korisnik.Prezime = (string)reader["Prezime"];
                korisnik.BrojTelefona = (string)reader["BrojTelefona"];
                korisnik.Email = (string)reader["Email"];
                korisnik.KorisnickoIme = (string)reader["KorisnickoIme"];
                korisnik.Lozinka = (string)reader["Lozinka"]; //ovo je hash-ovana lozinka
                korisnik.KodZaEnkripciju = (string)reader["KodZaEnkripciju"];
                korisnik.DatumRodjenja = (DateTime)reader["DatumRodjenja"];
                korisnik.Vlasnik = (bool)reader["Vlasnik"];
                return korisnik;
            }
            else
            {
                return null;
            }
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime}, email: {Email}, broj telefona: {BrojTelefona}";
        }
    }
}
