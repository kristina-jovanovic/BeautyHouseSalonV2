using Common.DTOs;
using InfrastructureEF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EFCore.KorisnikRepository
{
	public class KorisnikRepositoryEF : IKorisnikRepositoryEF
	{
		private readonly BeautyHouseDbContext dbContext;

		public KorisnikRepositoryEF(BeautyHouseDbContext dbContext)
		{
			this.dbContext = dbContext;
		}
		public async Task AddAsync(KorisnikDto t)
		{
			await dbContext.Set<KorisnikDto>().AddAsync(t);
			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteAsync(KorisnikDto t)
		{
			//proveru da li taj korisnik postoji obavljam u okviru sistemskih operacija
			dbContext.Set<KorisnikDto>().Remove(t);
			await dbContext.SaveChangesAsync();
		}

		public async Task<IEnumerable<KorisnikDto>> GetAllAsync()
		{
			return await dbContext.Set<KorisnikDto>().ToListAsync();
		}

		public async Task<KorisnikDto> GetByIdAsync(int id)
		{
			return await dbContext.Set<KorisnikDto>().FindAsync(id);
		}

		public async Task UpdateAsync(KorisnikDto t)
		{
			dbContext.Set<KorisnikDto>().Update(t);
			await dbContext.SaveChangesAsync();
		}
	}
}
