using Common.Domain;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.TipUslugeSO
{
	public class SOUcitajListuTipovaUsluga : SOBase
	{
		private TipUsluge tipUsluge;
		public List<IEntity> result;

		public SOUcitajListuTipovaUsluga(IRepository<IEntity> repository, TipUsluge tipUsluge) : base(repository)
		{
			this.tipUsluge = tipUsluge;
		}

		protected override async Task ExecuteConcreteOperationAsync()
		{
			result = (List<IEntity>)await repository.GetAllAsync(tipUsluge);
		}
	}
}
