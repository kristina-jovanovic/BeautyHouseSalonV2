using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs
{
	public class UslugaDto
	{
		public int UslugaID { get; set; }
		public string Naziv { get; set; }
		public double Cena { get; set; }
		public int TrajanjeUMinutima { get; set; }
		public TipUslugeDto TipUsluge { get; set; }
	}
}
