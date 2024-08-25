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

			//modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
			//modelBuilder.Entity<ProfilRadnika>().ToTable("ProfilRadnika");
			//modelBuilder.Entity<TipUsluge>().ToTable("TipUsluge");
			//modelBuilder.Entity<Usluga>().ToTable("Usluga");
			//modelBuilder.Entity<ZahtevZaRezervacijuTermina>().ToTable("ZahtevZaRezervacijuTermina");
		}

	}
}
