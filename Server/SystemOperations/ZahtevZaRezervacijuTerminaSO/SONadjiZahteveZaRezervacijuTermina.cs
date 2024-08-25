using Common.Domain;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ZahtevZaRezervacijuTerminaSO
{
	internal class SONadjiZahteveZaRezervacijuTermina : SOBase
	{
		private ProfilRadnika r;
		ZahtevZaRezervacijuTermina zahtevZaRezervacijuTermina;
		public List<IEntity> result;

		public SONadjiZahteveZaRezervacijuTermina(IRepository<IEntity> repository, ZahtevZaRezervacijuTermina zahtevZaRezervacijuTermina, ProfilRadnika r) : base(repository)
		{
			this.r = r;
			this.zahtevZaRezervacijuTermina = zahtevZaRezervacijuTermina;
		}

		protected override async Task ExecuteConcreteOperationAsync()
		{
			result = (List<IEntity>)await repository.GetAllWithFilterAsync(zahtevZaRezervacijuTermina,$"{r.Ime} {r.Prezime}");
		}
	}
}
