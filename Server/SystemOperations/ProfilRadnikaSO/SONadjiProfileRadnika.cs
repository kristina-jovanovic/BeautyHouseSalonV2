using Common.Domain;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ProfilRadnikaSO
{
	internal class SONadjiProfileRadnika : SOBase
	{
		private ProfilRadnika profilRadnika;
		private string filter;
		public List<IEntity> result;

		public SONadjiProfileRadnika(IRepository<IEntity> repository, ProfilRadnika profilRadnika, string filter) : base(repository)
		{
			this.profilRadnika = profilRadnika;
			this.filter = filter;
		}

		protected override async Task ExecuteConcreteOperationAsync()
		{
			result = (List<IEntity>)await repository.GetAllWithFilterAsync(profilRadnika,filter);
		}
	}
}
