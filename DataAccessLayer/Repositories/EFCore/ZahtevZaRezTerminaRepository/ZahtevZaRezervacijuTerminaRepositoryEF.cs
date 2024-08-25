using Common.Domain;
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
	public class ZahtevZaRezervacijuTerminaRepositoryEF : RepositoryEF<ZahtevZaRezervacijuTermina>
	{
		public ZahtevZaRezervacijuTerminaRepositoryEF(BeautyHouseDbContext dbContext) : base(dbContext)
		{
		}
		public override async Task AddAsync(ZahtevZaRezervacijuTermina entity)
		{
			await dbContext.Set<ZahtevZaRezervacijuTermina>().AddAsync(entity);
			await dbContext.SaveChangesAsync();
		}

		public override async Task DeleteAsync(ZahtevZaRezervacijuTermina entity)
		{
			//proveru da li taj zahtev postoji obavljam u okviru sistemskih operacija
			dbContext.Set<ZahtevZaRezervacijuTermina>().Remove(entity);
			await dbContext.SaveChangesAsync();
		}

		public override async Task<IEnumerable<IEntity?>> GetAllAsync(ZahtevZaRezervacijuTermina entity)
		{
			var zahtevi = await dbContext.Set<ZahtevZaRezervacijuTermina>().ToListAsync();
			return zahtevi.Cast<IEntity>();
		}

		public override async Task<IEnumerable<IEntity?>> GetAllWithFilterAsync(ZahtevZaRezervacijuTermina entity, string filter)
		{
			var zahtevi = await dbContext.Set<ZahtevZaRezervacijuTermina>().Where((z) => $"{z.Radnik.Ime} {z.Radnik.Prezime}".Contains(filter, StringComparison.CurrentCultureIgnoreCase)
			&& z.StatusZahteva == StatusZahteva.NaCekanju).ToListAsync();
			return zahtevi.Cast<IEntity>();
		}

		public override async Task<IEnumerable<IEntity?>> GetAllWithStatusAsync(ZahtevZaRezervacijuTermina entity, StatusZahteva status)
		{
			var zahtevi = await dbContext.Set<ZahtevZaRezervacijuTermina>().Where((z) => z.DatumIVremeTermina.Equals(entity.DatumIVremeTermina)
			&& z.Radnik == entity.Radnik && z.StatusZahteva == status).ToListAsync();
			return zahtevi.Cast<IEntity>();
		}

		public override async Task<IEntity?> GetByIdAsync(ZahtevZaRezervacijuTermina entity)
		{
			var zahtev = await dbContext.Set<ZahtevZaRezervacijuTermina>().FirstOrDefaultAsync((z) => z.VremeKreiranja.Equals(entity.VremeKreiranja)
			&& z.Korisnik.KorisnikID == entity.Korisnik.KorisnikID);
			return zahtev == null ? null : (IEntity)zahtev;
		}

		public override async Task UpdateAsync(ZahtevZaRezervacijuTermina entity)
		{
			dbContext.Set<ZahtevZaRezervacijuTermina>().Update(entity);
			await dbContext.SaveChangesAsync();
		}
	}
}
