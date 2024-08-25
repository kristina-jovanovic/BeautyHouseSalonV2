using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
	[Serializable]
	public class ZahtevZaRezervacijuTermina : IEntity
	{
		public int ZahtevID { get; set; }
		public string Napomena { get; set; }
		public DateTime VremeKreiranja { get; set; }
		public StatusZahteva StatusZahteva { get; set; }
		public DateTime DatumIVremeTermina { get; set; }
		public Korisnik Korisnik { get; set; }
		public ProfilRadnika Radnik { get; set; }
		public Usluga Usluga { get; set; }

		public string Aliaces()
		{
			return ", k.Ime as kIme, k.Prezime as kPrezime, pr.Ime as prIme, pr.Prezime as prPrezime";
		}

		public string FilterQuery(string filter)
		{
			return $"concat(lower(pr.Ime),' ',lower(pr.Prezime)) like concat('%',lower('{filter}'),'%')" +
				$" and StatusZahteva='NaCekanju'";
		}

		public string FilterQueryStatus(StatusZahteva status)
		{
			return $"DatumIVremeTermina='{DatumIVremeTermina.ToString("yyyyMMdd HH:mm")}' and Radnik={Radnik.RadnikID}" +
				$" and StatusZahteva='{status.ToString()}'";
		}

		public string GetById()
		{
			return $"VremeKreiranja='{VremeKreiranja.ToString("yyyyMMdd HH:mm:ss")}' and Korisnik={Korisnik.KorisnikID}";
		}

		public async Task<List<IEntity>> GetReaderListAsync(SqlDataReader reader)
		{
			List<IEntity> list = new List<IEntity>();
			while (await reader.ReadAsync())
			{
				list.Add(ReadFromReader(reader));
			}
			return list;
		}

		public async Task<IEntity> GetReaderResultAsync(SqlDataReader reader)
		{
			if (await reader.ReadAsync())
			{
				return ReadFromReader(reader);
			}
			else
			{
				return null;
			}
		}

		public string JoinQuery()
		{
			return "z JOIN Korisnik k ON z.Korisnik=k.KorisnikID" +
			" JOIN ProfilRadnika pr ON z.Radnik=pr.RadnikID" +
			" JOIN Usluga u ON z.Usluga=u.UslugaID" +
			" JOIN TipUsluge tu ON u.TipUsluge=tu.TipUslugeID";
		}

		public string PrimaryKey()
		{
			return $"ZahtevID={ZahtevID}";
		}

		public string TableName()
		{
			return "ZahtevZaRezervacijuTermina";
		}

		public override string ToString()
		{
			return $"Datum i vreme termina: {DatumIVremeTermina.ToString("dd.MM.yyyy. HH:mm")}\n" +
				$"Usluga: {Usluga}\nRadnik: {Radnik}\nKorisnik: {Korisnik}";
		}

		public string UpdateQuery()
		{
			return $"StatusZahteva='{StatusZahteva.ToString()}'";
		}

		public string Values()
		{
			return $"'{Napomena}', '{VremeKreiranja.ToString("yyyyMMdd HH:mm:ss")}', '{StatusZahteva.ToString()}'," +
			$"'{DatumIVremeTermina.ToString("yyyyMMdd HH:mm")}', {Korisnik.KorisnikID}, " +
			$"{Radnik.RadnikID}, {Usluga.UslugaID}";
		}

		private IEntity ReadFromReader(SqlDataReader reader)
		{
			ZahtevZaRezervacijuTermina zahtev = new ZahtevZaRezervacijuTermina();
			zahtev.ZahtevID = (int)reader["ZahtevID"];
			zahtev.Napomena = (string)reader["Napomena"];
			zahtev.VremeKreiranja = (DateTime)reader["VremeKreiranja"];
			zahtev.StatusZahteva = (StatusZahteva)Enum.Parse(typeof(StatusZahteva), (string)reader["StatusZahteva"]);
			zahtev.DatumIVremeTermina = (DateTime)reader["DatumIVremeTermina"];
			zahtev.Korisnik = new Korisnik
			{
				KorisnikID = (int)reader["KorisnikID"],
				Ime = (string)reader["kIme"],
				Prezime = (string)reader["kPrezime"],
				DatumRodjenja = (DateTime)reader["DatumRodjenja"],
				BrojTelefona = (string)reader["BrojTelefona"],
				Email = (string)reader["Email"],
				KorisnickoIme = (string)reader["KorisnickoIme"],
				Lozinka = (string)reader["Lozinka"],
				KodZaEnkripciju = (string)reader["KodZaEnkripciju"],
				Vlasnik = (bool)reader["Vlasnik"]
			};
			zahtev.Usluga = new Usluga
			{
				UslugaID = (int)reader["UslugaID"],
				Naziv = (string)reader["Naziv"],
				Cena = (double)reader["Cena"],
				TrajanjeUMinutima = (int)reader["TrajanjeUMinutima"],
				FotografijaUsluge = (string)reader["FotografijaUsluge"],
				TipUsluge = new TipUsluge
				{
					TipUslugeID = (int)reader["TipUslugeID"],
					NazivTipaUsluge = (string)reader["NazivTipaUsluge"]
				}
			};
			zahtev.Radnik = new ProfilRadnika
			{
				RadnikID = (int)reader["RadnikID"],
				Ime = (string)reader["prIme"],
				Prezime = (string)reader["prPrezime"],
				Opis = (string)reader["Opis"],
				Fotografija = (string)reader["Fotografija"],
				TipUsluge = new TipUsluge
				{
					TipUslugeID = (int)reader["TipUslugeID"],
					NazivTipaUsluge = (string)reader["NazivTipaUsluge"]
				}
			};
			return zahtev;
		}
	}
}
