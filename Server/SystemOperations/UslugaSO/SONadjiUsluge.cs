using Common.Domain;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.UslugaSO
{
	internal class SONadjiUsluge : SOBase
	{
		private Usluga usluga;
		private string filter;
		public List<IEntity> result;

		public SONadjiUsluge(IRepository<IEntity> repository, Usluga usluga, string filter) : base(repository)
		{
			this.usluga = usluga;
			this.filter = filter;
		}

		protected override async Task ExecuteConcreteOperationAsync()
		{
			result = (List<IEntity>)await repository.GetAllWithFilterAsync(usluga,filter);
		}
	}
}
