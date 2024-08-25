using Common.Domain;
using DBBroker;
using InfrastructureEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EFCore
{
	public abstract class RepositoryEF<T> : IRepository<T> where T : IEntity
	{
		protected readonly BeautyHouseDbContext dbContext;
		private IDbContextTransaction? transaction;

		protected RepositoryEF(BeautyHouseDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public async Task OpenConnectionAsync()
		{
			await dbContext.Database.GetDbConnection().OpenAsync();
		}

		public async Task BeginTransactionAsync()
		{
			transaction = await dbContext.Database.BeginTransactionAsync();
		}

		public async Task CloseConnectionAsync()
		{
			await dbContext.Database.GetDbConnection().CloseAsync();
		}

		public async Task CommitAsync()
		{
			await transaction?.CommitAsync();
		}

		public async Task RollbackAsync()
		{
			await transaction?.RollbackAsync();
		}

		public abstract Task<IEnumerable<IEntity?>> GetAllAsync(T entity);
		public abstract Task<IEnumerable<IEntity?>> GetAllWithFilterAsync(T entity, string filter);
		public abstract Task<IEnumerable<IEntity?>> GetAllWithStatusAsync(T entity, StatusZahteva status);
		public abstract Task<IEntity?> GetByIdAsync(T entity);
		public abstract Task AddAsync(T entity);
		public abstract Task UpdateAsync(T entity);
		public abstract Task DeleteAsync(T entity);
	}
}
