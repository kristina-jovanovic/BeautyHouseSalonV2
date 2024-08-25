using Common.Domain;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ProfilRadnikaSO
{
	internal class SOUcitajProfilRadnika : SOBase
	{
		private ProfilRadnika radnik;
		public IEntity result;
		public SOUcitajProfilRadnika(IRepository<IEntity> repository, ProfilRadnika radnik) : base(repository)
		{
			this.radnik = radnik;
		}

		protected override async Task ExecuteConcreteOperationAsync()
		{
			result = await repository.GetByIdAsync(radnik);
		}
	}
}
