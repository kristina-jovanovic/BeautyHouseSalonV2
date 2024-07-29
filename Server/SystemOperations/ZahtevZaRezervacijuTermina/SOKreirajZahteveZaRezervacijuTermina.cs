using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ZahtevZaRezervacijuTermina
{
	internal class SOKreirajZahteveZaRezervacijuTermina : SOBase
	{
		private List<Common.Domain.ZahtevZaRezervacijuTermina> zahtevi;
		public List<IEntity> result;

		public SOKreirajZahteveZaRezervacijuTermina(List<Common.Domain.ZahtevZaRezervacijuTermina> zahtevi)
		{
			this.zahtevi = zahtevi;
			result = new List<IEntity>();
		}

		protected override async Task ExecuteConcreteOperationAsync()
		{
			foreach (Common.Domain.ZahtevZaRezervacijuTermina zahtev in zahtevi)
			{
				await broker.InsertAsync(zahtev);
				result.Add(await broker.GetEntityByIdAsync(zahtev));
			}
		}
	}
}
