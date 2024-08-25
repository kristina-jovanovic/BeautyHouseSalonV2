using Common.Domain;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ZahtevZaRezervacijuTerminaSO
{
	internal class SOProveriRaspolozivostTermina : SOBase
	{
		private ZahtevZaRezervacijuTermina zahtev;
		public List<IEntity> result;
		public SOProveriRaspolozivostTermina(IRepository<IEntity> repository, ZahtevZaRezervacijuTermina zahtev) : base(repository)
		{
			this.zahtev = zahtev;
		}

		protected override async Task ExecuteConcreteOperationAsync()
		{
			result = (List<IEntity>)await repository.GetAllWithStatusAsync(zahtev, StatusZahteva.Odobren);
		}
	}
}
