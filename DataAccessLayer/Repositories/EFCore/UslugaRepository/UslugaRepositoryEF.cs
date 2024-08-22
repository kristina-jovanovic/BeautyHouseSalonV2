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
	public class UslugaRepositoryEF : IUslugaRepositoryEF
	{
		private readonly BeautyHouseDbContext dbContext;

		public UslugaRepositoryEF(BeautyHouseDbContext dbContext)
		{
			this.dbContext = dbContext;
		}
		public async Task AddAsync(UslugaDto t)
		{
			await dbContext.Set<UslugaDto>().AddAsync(t);
			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteAsync(UslugaDto t)
		{
			//proveru da li ta usluga postoji obavljam u okviru sistemskih operacija
			dbContext.Set<UslugaDto>().Remove(t);
			await dbContext.SaveChangesAsync();
		}

		public async Task<IEnumerable<UslugaDto>> GetAllAsync()
		{
			return await dbContext.Set<UslugaDto>().ToListAsync();
		}

		public async Task<UslugaDto> GetByIdAsync(int id)
		{
			return await dbContext.Set<UslugaDto>().FindAsync(id);
		}

		public async Task UpdateAsync(UslugaDto t)
		{
			dbContext.Set<UslugaDto>().Update(t);
			await dbContext.SaveChangesAsync();
		}
	}
}
