using Common.DTOs;
using InfrastructureEF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EFCore.ProfilUslugeRepository
{
	public class ProfilRadnikaRepositoryEF : IProfilRadnikaRepositoryEF
	{
		private readonly BeautyHouseDbContext dbContext;

		public ProfilRadnikaRepositoryEF(BeautyHouseDbContext dbContext)
        {
			this.dbContext = dbContext;
		}
		public async Task AddAsync(ProfilRadnikaDto t)
		{
			await dbContext.Set<ProfilRadnikaDto>().AddAsync(t);
			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteAsync(ProfilRadnikaDto t)
		{
			//proveru da li taj profil radnika postoji obavljam u okviru sistemskih operacija
			dbContext.Set<ProfilRadnikaDto>().Remove(t);
			await dbContext.SaveChangesAsync();
		}

		public async Task<IEnumerable<ProfilRadnikaDto>> GetAllAsync()
		{
			return await dbContext.Set<ProfilRadnikaDto>().ToListAsync();
		}

		public async Task<ProfilRadnikaDto> GetByIdAsync(int id)
		{
			return await dbContext.Set<ProfilRadnikaDto>().FindAsync(id);
		}

		public async Task UpdateAsync(ProfilRadnikaDto t)
		{
			dbContext.Set<ProfilRadnikaDto>().Update(t);
			await dbContext.SaveChangesAsync();
		}
	}
}
