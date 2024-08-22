using Common.DTOs;
using InfrastructureEF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EFCore.ZahtevZaRezTerminaRepository
{
	public class ZahtevZaRezervacijuTerminaRepositoryEF : IZahtevZaRezervacijuTerminaRepositoryEF
	{
		private readonly BeautyHouseDbContext dbContext;

		public ZahtevZaRezervacijuTerminaRepositoryEF(BeautyHouseDbContext dbContext)
		{
			this.dbContext = dbContext;
		}
		public async Task AddAsync(ZahtevZaRezervacijuTerminaDto t)
		{
			await dbContext.Set<ZahtevZaRezervacijuTerminaDto>().AddAsync(t);
			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteAsync(ZahtevZaRezervacijuTerminaDto t)
		{
			//proveru da li taj zahtev postoji obavljam u okviru sistemskih operacija
			dbContext.Set<ZahtevZaRezervacijuTerminaDto>().Remove(t);
			await dbContext.SaveChangesAsync();
		}

		public async Task<IEnumerable<ZahtevZaRezervacijuTerminaDto>> GetAllAsync()
		{
			return await dbContext.Set<ZahtevZaRezervacijuTerminaDto>().ToListAsync();
		}

		public async Task<ZahtevZaRezervacijuTerminaDto> GetByIdAsync(int id)
		{
			return await dbContext.Set<ZahtevZaRezervacijuTerminaDto>().FindAsync(id);
		}

		public async Task UpdateAsync(ZahtevZaRezervacijuTerminaDto t)
		{
			dbContext.Set<ZahtevZaRezervacijuTerminaDto>().Update(t);
			await dbContext.SaveChangesAsync();
		}
	}
}
