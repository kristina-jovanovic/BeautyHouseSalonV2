using Common.Domain;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ZahtevZaRezervacijuTerminaSO
{
	internal class SOKreirajZahteveZaRezervacijuTermina : SOBase
	{
		private List<ZahtevZaRezervacijuTermina> zahtevi;
		public List<IEntity> result;

		public SOKreirajZahteveZaRezervacijuTermina(IRepository<IEntity> repository, List<ZahtevZaRezervacijuTermina> zahtevi) : base(repository)
		{
			this.zahtevi = zahtevi;
			result = new List<IEntity>();
		}

		protected override async Task ExecuteConcreteOperationAsync()
		{
			foreach (ZahtevZaRezervacijuTermina zahtev in zahtevi)
			{
				await repository.AddAsync(zahtev);
				result.Add(await repository.GetByIdAsync(zahtev));
			}
		}
	}
}
