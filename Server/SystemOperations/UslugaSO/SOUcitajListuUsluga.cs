using Common.Domain;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.UslugaSO
{
	internal class SOUcitajListuUsluga : SOBase
	{
		internal List<IEntity> result;
		private Usluga usluga;

		public SOUcitajListuUsluga(IRepository<IEntity> repository, Usluga usluga) : base(repository)
		{
			this.usluga = usluga;
		}

		protected override async Task ExecuteConcreteOperationAsync()
		{
			result = (List<IEntity>)await repository.GetAllAsync(usluga);
		}
	}
}
