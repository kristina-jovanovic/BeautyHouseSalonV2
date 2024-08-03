using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs
{
	public class KorisnikDto
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
	}
}
