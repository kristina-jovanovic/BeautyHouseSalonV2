using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs
{
	public class ZahtevZaRezervacijuTerminaDto
	{
		public int ZahtevID { get; set; }
		public string Napomena { get; set; }
		public DateTime VremeKreiranja { get; set; }
		public StatusZahteva StatusZahteva { get; set; }
		public DateTime DatumIVremeTermina { get; set; }
		public KorisnikDto Korisnik { get; set; }
		public ProfilRadnikaDto Radnik { get; set; }
		public UslugaDto Usluga { get; set; }
	}
}
