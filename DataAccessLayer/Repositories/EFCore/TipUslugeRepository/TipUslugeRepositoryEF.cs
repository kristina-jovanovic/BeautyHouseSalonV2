using Common.Domain;
using Common.DTOs;
using InfrastructureEF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EFCore.TipUslugeRepository
{
	public class TipUslugeRepositoryEF : RepositoryEF<TipUsluge>
	{

		public TipUslugeRepositoryEF(BeautyHouseDbContext dbContext) : base(dbContext)
		{
		}
		public override async Task AddAsync(TipUsluge entity)
		{
			await dbContext.Set<TipUsluge>().AddAsync(entity);
			await dbContext.SaveChangesAsync();
		}

		public override async Task DeleteAsync(TipUsluge entity)
		{
			//proveru da li taj tip usluge postoji obavljam u okviru sistemskih operacija
			dbContext.Set<TipUsluge>().Remove(entity);
			await dbContext.SaveChangesAsync();
		}

		public override async Task<IEnumerable<IEntity?>> GetAllAsync(TipUsluge entity)
		{
			var tipovi = await dbContext.Set<TipUsluge>().ToListAsync();
			return tipovi.Cast<IEntity>();
		}

		public override async Task<IEnumerable<IEntity?>> GetAllWithFilterAsync(TipUsluge entity, string filter)
		{
			var tipovi = await dbContext.Set<TipUsluge>().Where((t) => t.NazivTipaUsluge.Contains(filter, StringComparison.CurrentCultureIgnoreCase)).ToListAsync();
			return tipovi.Cast<IEntity>();
		}

		public override Task<IEnumerable<IEntity?>> GetAllWithStatusAsync(TipUsluge entity, StatusZahteva status)
		{
			throw new NotImplementedException();
		}

		public override Task<IEntity?> GetByIdAsync(TipUsluge entity)
		{
			throw new NotImplementedException();
		}

		public override async Task UpdateAsync(TipUsluge entity)
		{
			dbContext.Set<TipUsluge>().Update(entity);
			await dbContext.SaveChangesAsync();
		}
	}
}
