using Common.Domain;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.UslugaSO
{
	internal class SOObrisiUslugu : SOBase
	{
		public bool result;
		private Usluga usluga;

		public SOObrisiUslugu(IRepository<IEntity> repository, Usluga usluga) : base(repository)
		{
			this.usluga = usluga;
		}

		protected override async Task ExecuteConcreteOperationAsync()
		{
			try
			{
				//dodato naknadno - provera da li postoji ta usluga
				if (await repository.GetByIdAsync(usluga) == null)
				{
					result = false;
				}
				else
				{
					await repository.DeleteAsync(usluga);
					result = true;
				}
			}
			catch (Exception)
			{
				result = false;
			}
		}
	}
}
