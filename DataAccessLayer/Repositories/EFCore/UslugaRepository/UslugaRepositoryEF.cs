using Common.Domain;
using Common.DTOs;
using InfrastructureEF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EFCore.UslugaRepository
{
	public class UslugaRepositoryEF : RepositoryEF<Usluga>
	{

		public UslugaRepositoryEF(BeautyHouseDbContext dbContext) : base(dbContext)
		{
		}
		public override async Task AddAsync(Usluga entity)
		{
			await dbContext.Set<Usluga>().AddAsync(entity);
			await dbContext.SaveChangesAsync();
		}

		public override async Task DeleteAsync(Usluga entity)
		{
			//proveru da li ta usluga postoji obavljam u okviru sistemskih operacija
			dbContext.Set<Usluga>().Remove(entity);
			await dbContext.SaveChangesAsync();
		}

		public override async Task<IEnumerable<IEntity?>> GetAllAsync(Usluga entity)
		{
			var usluge = await dbContext.Set<Usluga>().ToListAsync();
			return usluge.Cast<IEntity>();
		}

		public override async Task<IEnumerable<IEntity?>> GetAllWithFilterAsync(Usluga entity, string filter)
		{
			var usluge = await dbContext.Set<Usluga>().Where((u) => u.Naziv.Contains(filter, StringComparison.CurrentCultureIgnoreCase)
			|| u.TipUsluge.NazivTipaUsluge.Contains(filter, StringComparison.CurrentCultureIgnoreCase)).ToListAsync();
			return usluge.Cast<IEntity>();
		}

		public override Task<IEnumerable<IEntity?>> GetAllWithStatusAsync(Usluga entity, StatusZahteva status)
		{
			throw new NotImplementedException();
		}

		public override async Task<IEntity?> GetByIdAsync(Usluga entity)
		{
			var usluga = await dbContext.Set<Usluga>().FirstOrDefaultAsync((u) => u.Naziv == entity.Naziv || u.UslugaID == entity.UslugaID);
			return usluga == null ? null : (IEntity)usluga;
		}

		public override async Task UpdateAsync(Usluga entity)
		{
			dbContext.Set<Usluga>().Update(entity);
			await dbContext.SaveChangesAsync();
		}
	}
}
