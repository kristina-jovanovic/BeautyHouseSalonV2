using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs
{
	public class ProfilRadnikaDto
	{
		public int RadnikID { get; set; }
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public string Opis { get; set; }
		public string Fotografija { get; set; } //url fotografije
		public TipUslugeDto TipUsluge { get; set; }
	}
}
