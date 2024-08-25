using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.DBBroker
{
	public class RepositoryDBB : IRepository<IEntity>
	{
		protected readonly Broker broker;
		public RepositoryDBB(Broker broker)
		{
			this.broker = broker;
		}

		public async Task OpenConnectionAsync()
		{
			await broker.OpenConnectionAsync();
		}

		public async Task BeginTransactionAsync()
		{
			await broker.BeginTransactionAsync();
		}

		public async Task CloseConnectionAsync()
		{
			await broker.CloseConnectionAsync();
		}

		public async Task CommitAsync()
		{
			await broker.CommitAsync();
		}

		public async Task RollbackAsync()
		{
			await broker.RollbackAsync();
		}

		public async Task<IEnumerable<IEntity?>> GetAllAsync(IEntity entity)
		{
			return await broker.ReadAllAsync(entity);

		}

		public async Task<IEnumerable<IEntity?>> GetAllWithFilterAsync(IEntity entity,string filter)
		{
			return await broker.ReadAllWithFilterAsync(entity, filter);

		}

		public async Task<IEnumerable<IEntity?>> GetAllWithStatusAsync(IEntity entity, StatusZahteva status)
		{
			return await broker.GetEntitiesByIdAsync(entity, status);

		}

		public async Task<IEntity?> GetByIdAsync(IEntity entity)
		{
			return await broker.GetEntityByIdAsync(entity);

		}

		public async Task AddAsync(IEntity entity)
		{
			await broker.InsertAsync(entity);
		}

		public async Task UpdateAsync(IEntity entity)
		{
			await broker.UpdateAsync(entity);
		}

		public async Task DeleteAsync(IEntity entity)
		{
			await broker.DeleteAsync(entity);
		}

	}
}
