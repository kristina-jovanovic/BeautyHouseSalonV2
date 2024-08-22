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
	public class TipUslugeRepositoryEF : ITipUslugeRepositoryEF
	{
		private readonly BeautyHouseDbContext dbContext;

		public TipUslugeRepositoryEF(BeautyHouseDbContext dbContext)
		{
			this.dbContext = dbContext;
		}
		public async Task AddAsync(TipUslugeDto t)
		{
			await dbContext.Set<TipUslugeDto>().AddAsync(t);
			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteAsync(TipUslugeDto t)
		{
			//proveru da li taj tip usluge postoji obavljam u okviru sistemskih operacija
			dbContext.Set<TipUslugeDto>().Remove(t);
			await dbContext.SaveChangesAsync();
		}

		public async Task<IEnumerable<TipUslugeDto>> GetAllAsync()
		{
			return await dbContext.Set<TipUslugeDto>().ToListAsync();
		}

		public async Task<TipUslugeDto> GetByIdAsync(int id)
		{
			return await dbContext.Set<TipUslugeDto>().FindAsync(id);
		}

		public async Task UpdateAsync(TipUslugeDto t)
		{
			dbContext.Set<TipUslugeDto>().Update(t);
			await dbContext.SaveChangesAsync();
		}
	}
}
