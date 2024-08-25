using Common.Domain;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ProfilRadnikaSO
{
	internal class SOKreirajProfilRadnika : SOBase
	{
		internal IEntity result;
		private ProfilRadnika radnik;

		public SOKreirajProfilRadnika(IRepository<IEntity> repository, ProfilRadnika radnik) : base(repository)
		{
			this.radnik = radnik;
		}

		protected override async Task ExecuteConcreteOperationAsync()
		{
			await repository.AddAsync(radnik);
			result = await repository.GetByIdAsync(radnik);
		}
	}
}
