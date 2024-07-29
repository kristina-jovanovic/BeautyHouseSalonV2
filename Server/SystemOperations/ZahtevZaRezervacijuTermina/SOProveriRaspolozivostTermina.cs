using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ZahtevZaRezervacijuTermina
{
	internal class SOProveriRaspolozivostTermina : SOBase
	{
		private Common.Domain.ZahtevZaRezervacijuTermina zahtev;
		public List<IEntity> result;
		public SOProveriRaspolozivostTermina(Common.Domain.ZahtevZaRezervacijuTermina zahtev)
		{
			this.zahtev = zahtev;
		}

		protected override async Task ExecuteConcreteOperationAsync()
		{
			result = await broker.GetEntitiesByIdAsync(zahtev, StatusZahteva.Odobren);
		}
	}
}
