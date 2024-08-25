using Common.Domain;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ZahtevZaRezervacijuTerminaSO
{
	internal class SOZakaziTermine : SOBase
	{
		public List<IEntity> result;
		private List<ZahtevZaRezervacijuTermina> zahtevi;
		private StatusZahteva status;

		public SOZakaziTermine(IRepository<IEntity> repository, List<ZahtevZaRezervacijuTermina> zahtevi, StatusZahteva status) : base(repository)
		{
			this.zahtevi = zahtevi;
			this.status = status;
			result = new List<IEntity>();
		}

		protected override async Task ExecuteConcreteOperationAsync()
		{
			foreach (ZahtevZaRezervacijuTermina zahtev in zahtevi)
			{
				zahtev.StatusZahteva = status;
				await repository.UpdateAsync(zahtev);
				result.Add(await repository.GetByIdAsync(zahtev));
			}
		}
	}
}
