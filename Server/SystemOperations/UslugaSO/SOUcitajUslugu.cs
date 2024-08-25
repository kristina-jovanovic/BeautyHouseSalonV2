using Common.Domain;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.UslugaSO
{
	internal class SOUcitajUslugu : SOBase
	{
		internal IEntity result;
		private Usluga usluga;

		public SOUcitajUslugu(IRepository<IEntity> repository, Usluga usluga) : base(repository)
		{
			this.usluga = usluga;
		}

		protected override async Task ExecuteConcreteOperationAsync()
		{
			result = await repository.GetByIdAsync(usluga);
		}
	}
}
