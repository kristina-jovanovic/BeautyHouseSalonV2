using Common.Domain;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ZahtevZaRezervacijuTerminaSO
{
	internal class SOUcitajListuZahtevaZaRezervacijuTermina : SOBase
	{
		private ZahtevZaRezervacijuTermina z;
		public List<IEntity> result;
		public SOUcitajListuZahtevaZaRezervacijuTermina(IRepository<IEntity> repository, ZahtevZaRezervacijuTermina z) : base(repository)
		{
			this.z = z;
		}

		protected override async Task ExecuteConcreteOperationAsync()
		{
			result = (List<IEntity>)await repository.GetAllWithStatusAsync(z, StatusZahteva.NaCekanju);
		}
	}
}
