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

		public string Aliaces()
		{
			return "";
		}

		public string GetById()
		{
			return $"KorisnickoIme='{KorisnickoIme}'";
		}

		public string JoinQuery()
		{
			return "";
		}

		public string PrimaryKey()
		{
			return KorisnikID.ToString();
		}

		public string TableName()
		{
			return "Korisnik";
		}

		public string UpdateQuery()
		{
			return null;
		}

		public string Values()
		{
			return $"'{Ime}', '{Prezime}', '{DatumRodjenja.ToString("yyyyMMdd")}', '{BrojTelefona}', '{Email}', '{KorisnickoIme}', " +
				$"'{Lozinka}', '{KodZaEnkripciju}', {(Vlasnik ? 1 : 0)}";
		}

		public string FilterQuery(string filter)
		{
			return null;
		}

		public string FilterQueryStatus(StatusZahteva status)
		{
			return null;
		}

		public Task<List<IEntity>> GetReaderListAsync(SqlDataReader reader)
		{
			return null;
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
