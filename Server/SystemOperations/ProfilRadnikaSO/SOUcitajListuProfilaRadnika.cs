using Common.Domain;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ProfilRadnikaSO
{
	internal class SOUcitajListuProfilaRadnika : SOBase
	{
		private ProfilRadnika profilRadnika;
		public List<IEntity> result;

		public SOUcitajListuProfilaRadnika(IRepository<IEntity> repository,ProfilRadnika profilRadnika):base(repository)
		{
			this.profilRadnika = profilRadnika;
		}

		protected override async Task ExecuteConcreteOperationAsync()
		{
			result = (List<IEntity>)await repository.GetAllAsync(profilRadnika);
		}
	}
}
