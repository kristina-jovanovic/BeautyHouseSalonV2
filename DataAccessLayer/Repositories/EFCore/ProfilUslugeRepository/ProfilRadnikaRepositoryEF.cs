using Common.Domain;
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
	public class ProfilRadnikaRepositoryEF : RepositoryEF<ProfilRadnika>
	{

		public ProfilRadnikaRepositoryEF(BeautyHouseDbContext dbContext) : base(dbContext)
		{
		}
		public override async Task AddAsync(ProfilRadnika entity)
		{
			await dbContext.Set<ProfilRadnika>().AddAsync(entity);
			await dbContext.SaveChangesAsync();
		}

		public override async Task DeleteAsync(ProfilRadnika entity)
		{
			//proveru da li taj profil radnika postoji obavljam u okviru sistemskih operacija
			dbContext.Set<ProfilRadnika>().Remove(entity);
			await dbContext.SaveChangesAsync();
		}

		public override async Task<IEnumerable<IEntity?>> GetAllAsync(ProfilRadnika entity)
		{
			var radnici = await dbContext.Set<ProfilRadnika>().ToListAsync();
			return radnici.Cast<IEntity>();
		}

		public override async Task<IEnumerable<IEntity?>> GetAllWithFilterAsync(ProfilRadnika entity, string filter)
		{
			var radnici = await dbContext.Set<ProfilRadnika>().Where((r) => $"{r.Ime} {r.Prezime}".Contains(filter, StringComparison.CurrentCultureIgnoreCase)
			|| r.TipUsluge.NazivTipaUsluge.Contains(filter, StringComparison.CurrentCultureIgnoreCase)).ToListAsync();
			return radnici.Cast<IEntity>();
		}

		public override Task<IEnumerable<IEntity?>> GetAllWithStatusAsync(ProfilRadnika entity, StatusZahteva status)
		{
			throw new NotImplementedException();
		}

		public override async Task<IEntity?> GetByIdAsync(ProfilRadnika entity)
		{
			var radnik = await dbContext.Set<ProfilRadnika>().FirstOrDefaultAsync((r) => (r.Ime == entity.Ime && r.Prezime == entity.Prezime)
			|| r.RadnikID == entity.RadnikID);
			return radnik == null ? null : (IEntity)radnik;
		}

		public override async Task UpdateAsync(ProfilRadnika entity)
		{
			dbContext.Set<ProfilRadnika>().Update(entity);
			await dbContext.SaveChangesAsync();
		}
	}
}
