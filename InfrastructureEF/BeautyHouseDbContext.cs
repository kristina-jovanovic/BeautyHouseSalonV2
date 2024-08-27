using Common.Domain;
using Common.DTOs;
using InfrastructureEF.Extensions;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureEF
{
	public class BeautyHouseDbContext : DbContext
	{
		public BeautyHouseDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
		{

		}

		public DbSet<Korisnik> Korisnik { get; set; }
		public DbSet<ProfilRadnika> ProfilRadnika { get; set; }
		public DbSet<TipUsluge> TipUsluge { get; set; }
		public DbSet<Usluga> Usluga { get; set; }
		public DbSet<ZahtevZaRezervacijuTermina> ZahtevZaRezervacijuTermina { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.RemovePluralizingTableNameConvention();

			//postavljanje primarnih kljuceva
			modelBuilder.Entity<Korisnik>().HasKey(k => k.KorisnikID); 
			modelBuilder.Entity<ProfilRadnika>().HasKey(p => p.RadnikID);
			modelBuilder.Entity<TipUsluge>().HasKey(t => t.TipUslugeID);
			modelBuilder.Entity<Usluga>().HasKey(u => u.UslugaID);
			modelBuilder.Entity<ZahtevZaRezervacijuTermina>().HasKey(z => z.ZahtevID);


		}

	}
}
