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
		protected Broker broker;
		public SOBase()
		{
			broker = new Broker();
		}
		public async Task ExecuteTemplate()
		{
			try
			{
				await broker.OpenConnectionAsync();
				await broker.BeginTransactionAsync();
				await ExecuteConcreteOperationAsync();
				await broker.CommitAsync();
			}
			catch (Exception ex)
			{
				await broker.RollbackAsync();
				throw ex;
			}
			finally
			{
				await broker.CloseConnectionAsync();
			}
		}

		protected abstract Task ExecuteConcreteOperationAsync();
	}
}
