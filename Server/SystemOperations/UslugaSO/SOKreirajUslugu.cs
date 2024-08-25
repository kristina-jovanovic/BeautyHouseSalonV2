using Common.Domain;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.UslugaSO
{
	public class SOKreirajUslugu : SOBase
	{
		private Usluga usluga;
		public IEntity result;

		public SOKreirajUslugu(IRepository<IEntity> repository, Usluga usluga) : base(repository)
		{
			this.usluga = usluga;
		}

		protected override async Task ExecuteConcreteOperationAsync()
		{
			try
			{
				await repository.AddAsync(usluga);
				result = await repository.GetByIdAsync(usluga);
			}
			catch (Exception)
			{
				//unique ogranicenje je naruseno, vec postoji usluga sa tim nazivom u bazi
				result = null;
			}
		}
	}
}
