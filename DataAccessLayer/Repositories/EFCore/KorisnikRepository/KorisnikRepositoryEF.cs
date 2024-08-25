using Common.Domain;
using Common.DTOs;
using InfrastructureEF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EFCore.KorisnikRepository
{
	public class KorisnikRepositoryEF : RepositoryEF<Korisnik>
	{
		public KorisnikRepositoryEF(BeautyHouseDbContext dbContext) : base(dbContext)
		{
		}

		public override async Task AddAsync(Korisnik entity)
		{
			await dbContext.Set<Korisnik>().AddAsync(entity);
			await dbContext.SaveChangesAsync();
		}

		public override async Task DeleteAsync(Korisnik entity)
		{
			//proveru da li taj korisnik postoji obavljam u okviru sistemskih operacija
			dbContext.Set<Korisnik>().Remove(entity);
			await dbContext.SaveChangesAsync();
		}

		public override async Task<IEnumerable<IEntity?>> GetAllAsync(Korisnik entity)
		{
			var korisnici = await dbContext.Set<Korisnik>().ToListAsync();
			return korisnici.Cast<IEntity>();
		}

		public override Task<IEnumerable<IEntity?>> GetAllWithFilterAsync(Korisnik entity, string filter)
		{
			//return await dbContext.Set<Korisnik>().Where((k) => $"{k.Ime} {k.Prezime}".Contains(filter, StringComparison.CurrentCultureIgnoreCase)).ToListAsync();
			throw new NotImplementedException();
		}

		public override Task<IEnumerable<IEntity?>> GetAllWithStatusAsync(Korisnik entity, StatusZahteva status)
		{
			throw new NotImplementedException();
		}

		public override async Task<IEntity?> GetByIdAsync(Korisnik entity)
		{
			var korisnik = await dbContext.Set<Korisnik>().FirstOrDefaultAsync((k) => k.KorisnickoIme == entity.KorisnickoIme);
			return korisnik == null ? null : (IEntity)korisnik;
		}

		public override async Task UpdateAsync(Korisnik entity)
		{
			dbContext.Set<Korisnik>().Update(entity);
			await dbContext.SaveChangesAsync();
		}
	}
}
