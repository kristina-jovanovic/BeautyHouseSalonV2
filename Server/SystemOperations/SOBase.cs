using Common.Domain;
using DataAccessLayer;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
	public abstract class SOBase
	{
		protected readonly IRepository<IEntity> repository;

		public SOBase(IRepository<IEntity> repository)
		{
			this.repository = repository;
		}
		public async Task ExecuteTemplate()
		{
			try
			{
				await repository.OpenConnectionAsync();
				await repository.BeginTransactionAsync();
				await ExecuteConcreteOperationAsync();
				await repository.CommitAsync();
			}
			catch (Exception ex)
			{
				await repository.RollbackAsync();
				throw ex;
			}
			finally
			{
				await repository.CloseConnectionAsync();
			}
		}

		protected abstract Task ExecuteConcreteOperationAsync();
	}
}
