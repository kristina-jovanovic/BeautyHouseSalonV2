using Common.Domain;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.UslugaSO
{
	internal class SOIzmeniUslugu : SOBase
	{
		internal IEntity result;
		private Usluga usluga;

		public SOIzmeniUslugu(IRepository<IEntity> repository,Usluga usluga):base(repository)
		{
			this.usluga = usluga;
		}

		protected override async Task ExecuteConcreteOperationAsync()
		{
			try
			{
				await repository.UpdateAsync(usluga);
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
