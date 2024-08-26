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
	public class RepositoryEF : IRepository<IEntity>
	{
		protected readonly BeautyHouseDbContext dbContext;
		private IDbContextTransaction? transaction;

		public RepositoryEF(BeautyHouseDbContext dbContext)
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
			await transaction.RollbackAsync();
		}

		public async Task<IEnumerable<IEntity?>> GetAllAsync(IEntity entity)
		{
			return await dbContext.Set<IEntity>().ToListAsync();
		}

		public async Task<IEnumerable<IEntity?>> GetAllWithFilterAsync(IEntity entity, string filter)
		{
			//var zahtevi = await dbContext.Set<T>().Where((z) => $"{z.Radnik.Ime} {z.Radnik.Prezime}".Contains(filter, StringComparison.CurrentCultureIgnoreCase)
			//&& z.StatusZahteva == StatusZahteva.NaCekanju).ToListAsync();
			//return zahtevi.Cast<IEntity>();
			return await dbContext.Set<IEntity>().FromSqlInterpolated($"select *{entity.Aliaces()} from {entity.TableName()} {entity.JoinQuery()} where {entity.FilterQuery(filter)}").ToListAsync();

		}

		public async Task<IEnumerable<IEntity?>> GetAllWithStatusAsync(IEntity entity, StatusZahteva status)
		{
			return await dbContext.Set<IEntity>().FromSqlInterpolated($"select *{entity.Aliaces()} from {entity.TableName()} {entity.JoinQuery()} where {entity.FilterQueryStatus(status)}").ToListAsync();

		}

		public async Task<IEntity?> GetByIdAsync(IEntity entity)
		{
			return await dbContext.Set<IEntity>().FromSqlInterpolated($"select *{entity.Aliaces()} from {entity.TableName()} {entity.JoinQuery()} where {entity.GetById()}").FirstOrDefaultAsync();

		}

		public async Task AddAsync(IEntity entity)
		{
			await dbContext.Set<IEntity>().AddAsync(entity);
			await dbContext.SaveChangesAsync();
		}

		public async Task UpdateAsync(IEntity entity)
		{
			dbContext.Set<IEntity>().Update(entity);
			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteAsync(IEntity entity)
		{
			//proveru da li taj korisnik postoji obavljam u okviru sistemskih operacija
			dbContext.Set<IEntity>().Remove(entity);
			await dbContext.SaveChangesAsync();
		}
	}
}
