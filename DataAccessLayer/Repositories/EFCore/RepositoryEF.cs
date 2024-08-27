using Common.Domain;
using DBBroker;
using InfrastructureEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
			//// Dobij tip entiteta
			//Type entityType = entity.GetType();

			//// Dobij DbSet koristeći refleksiju
			//var dbSet = dbContext.GetType()
			//					 .GetMethod("Set", new Type[] { })
			//					 .MakeGenericMethod(entityType)
			//					 .Invoke(dbContext, null);

			//// Pretvori dbSet u IEnumerable<IEntity> i izvrši upit
			//var result = await ((IQueryable<IEntity>)dbSet).ToListAsync();

			//return result;

			return await dbContext.Set<IEntity>().ToListAsync();
		}

		public async Task<IEnumerable<IEntity?>> GetAllWithFilterAsync(IEntity entity, string filter)
		{
			//	// Dobij stvarni tip objekta koji implementira IEntity
			//	var entityType = entity.GetType();

			//	// Pozovi dbContext.Set<T>() dinamički koristeći refleksiju
			//	var dbSet = typeof(DbContext)
			//		.GetMethod("Set", new Type[] { })
			//		.MakeGenericMethod(entityType)
			//		.Invoke(dbContext, null);

			//	// Pozovi FromSqlInterpolated metod dinamički
			//	var fromSqlInterpolatedMethod = dbSet.GetType().GetMethod("FromSqlInterpolated", new[] { typeof(FormattableString) });
			//	var query = (IQueryable<IEntity?>)fromSqlInterpolatedMethod.Invoke(dbSet, new object[]
			//	{
			//(FormattableString)$"select *{entity.Aliaces()} from {entity.TableName()} {entity.JoinQuery()} where {entity.FilterQuery(filter)}"
			//	});

			//	// Izvrši ToListAsync dinamički
			//	var toListAsyncMethod = typeof(EntityFrameworkQueryableExtensions)
			//		.GetMethod("ToListAsync", new[] { typeof(IQueryable<>).MakeGenericType(entityType), typeof(CancellationToken) })
			//		.MakeGenericMethod(entityType);

			//	var result = await (Task<IEnumerable<IEntity?>>)toListAsyncMethod.Invoke(null, new object[] { query, CancellationToken.None });

			//	return result;

			//var zahtevi = await dbContext.Set<T>().Where((z) => $"{z.Radnik.Ime} {z.Radnik.Prezime}".Contains(filter, StringComparison.CurrentCultureIgnoreCase)
			//&& z.StatusZahteva == StatusZahteva.NaCekanju).ToListAsync();
			//return zahtevi.Cast<IEntity>();
			return await dbContext.Set<IEntity>().FromSqlInterpolated($"select *{entity.Aliaces()} from {entity.TableName()} {entity.JoinQuery()} where {entity.FilterQuery(filter)}").ToListAsync();

		}

		public async Task<IEnumerable<IEntity?>> GetAllWithStatusAsync(IEntity entity, StatusZahteva status)
		{
			//// Dobij stvarni tip objekta koji implementira IEntity
			//var entityType = entity.GetType();

			//// Pozovi dbContext.Set<T>() dinamički koristeći refleksiju
			//var dbSet = typeof(DbContext)
			//	.GetMethod("Set", new Type[] { })
			//	.MakeGenericMethod(entityType)
			//	.Invoke(dbContext, null);

			//// Pozovi FromSqlInterpolated metod dinamički
			//var fromSqlInterpolatedMethod = dbSet.GetType().GetMethod("FromSqlInterpolated", new[] { typeof(FormattableString) });
			//var query = (IQueryable<IEntity?>)fromSqlInterpolatedMethod.Invoke(dbSet, new object[]
			//{
			//	(FormattableString)$"select * {entity.Aliaces()} from {entity.TableName()} {entity.JoinQuery()} where {entity.FilterQueryStatus(status)}"
			//});

			//// Izvrši ToListAsync dinamički
			//var toListAsyncMethod = typeof(EntityFrameworkQueryableExtensions)
			//	.GetMethod("ToListAsync", new[] { typeof(IQueryable<>).MakeGenericType(entityType), typeof(CancellationToken) })
			//	.MakeGenericMethod(entityType);

			//var result = await (Task<IEnumerable<IEntity?>>)toListAsyncMethod.Invoke(null, new object[] { query, CancellationToken.None });

			//return result;

			return await dbContext.Set<IEntity>().FromSqlInterpolated($"select *{entity.Aliaces()} from {entity.TableName()} {entity.JoinQuery()} where {entity.FilterQueryStatus(status)}").ToListAsync();

		}

		public async Task<IEntity?> GetByIdAsync(IEntity entity)
		{
			//// Ručno generišite tip i pozovite Set<T>
			//try
			//{
			//	if (entity is Korisnik)
			//	{
			//		return await dbContext.Set<Korisnik>().FromSqlRaw($"select * {entity.Aliaces()} from {entity.TableName()} {entity.JoinQuery()} where {entity.GetById()}").FirstOrDefaultAsync();
			//	}
			//}
			//catch (Exception ex)
			//{
			//	Debug.WriteLine(ex);
			//}

			//// Dodaj druge entitete po potrebi

			//return null;


			return await dbContext.Set<IEntity>().FromSqlInterpolated($"select *{entity.Aliaces()} from {entity.TableName()} {entity.JoinQuery()} where {entity.GetById()}").FirstOrDefaultAsync();

		}


		public async Task AddAsync(IEntity entity)
		{
			//// Dobij stvarni tip objekta koji implementira IEntity
			//var entityType = entity.GetType();

			//// Pozovi dbContext.Set<T>() dinamički koristeći refleksiju
			//var dbSet = typeof(DbContext)
			//	.GetMethod("Set", new Type[] { })
			//	.MakeGenericMethod(entityType)
			//	.Invoke(dbContext, null);

			//// Pozovi AddAsync metod dinamički
			//var addAsyncMethod = dbSet.GetType().GetMethod("AddAsync", new[] { entityType, typeof(CancellationToken) });
			//var task = (Task)addAsyncMethod.Invoke(dbSet, new object[] { entity, CancellationToken.None });
			//await task;

			//// Sačuvaj promene
			//await dbContext.SaveChangesAsync();

			await dbContext.Set<IEntity>().AddAsync(entity);
			await dbContext.SaveChangesAsync();
		}

		public async Task UpdateAsync(IEntity entity)
		{
			//// Dobij stvarni tip objekta koji implementira IEntity
			//var entityType = entity.GetType();

			//// Pozovi dbContext.Set<T>() dinamički koristeći refleksiju
			//var dbSet = typeof(DbContext)
			//	.GetMethod("Set", new Type[] { })
			//	.MakeGenericMethod(entityType)
			//	.Invoke(dbContext, null);

			//// Pozovi Update metod dinamički
			//var updateMethod = dbSet.GetType().GetMethod("Update", new[] { entityType });
			//updateMethod.Invoke(dbSet, new object[] { entity });

			//// Sačuvaj promene
			//await dbContext.SaveChangesAsync();

			dbContext.Set<IEntity>().Update(entity);
			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteAsync(IEntity entity)
		{
			//// Dobij stvarni tip objekta koji implementira IEntity
			//var entityType = entity.GetType();

			//// Pozovi dbContext.Set<T>() dinamički koristeći refleksiju
			//var dbSet = typeof(DbContext)
			//	.GetMethod("Set", new Type[] { })
			//	.MakeGenericMethod(entityType)
			//	.Invoke(dbContext, null);

			//// Pozovi Remove metod dinamički
			//var removeMethod = dbSet.GetType().GetMethod("Remove", new[] { entityType });
			//removeMethod.Invoke(dbSet, new object[] { entity });

			//// Sačuvaj promene
			//await dbContext.SaveChangesAsync();

			//proveru da li taj korisnik postoji obavljam u okviru sistemskih operacija
			dbContext.Set<IEntity>().Remove(entity);
			await dbContext.SaveChangesAsync();
		}

	}
}
