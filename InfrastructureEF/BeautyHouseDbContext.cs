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

        public DbSet<KorisnikDto> Korisnik { get; set; }
        public DbSet<ProfilRadnikaDto> ProfilRadnika { get; set; }
        public DbSet<TipUslugeDto> TipUsluge { get; set; }
        public DbSet<UslugaDto> Usluga { get; set; }
        public DbSet<ZahtevZaRezervacijuTerminaDto> ZahtevZaRezervacijuTermina { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.RemovePluralizingTableNameConvention();

			modelBuilder.Entity<KorisnikDto>().ToTable("Korisnik");
			modelBuilder.Entity<ProfilRadnikaDto>().ToTable("ProfilRadnika");
			modelBuilder.Entity<TipUslugeDto>().ToTable("TipUsluge");
			modelBuilder.Entity<UslugaDto>().ToTable("Usluga");
			modelBuilder.Entity<ZahtevZaRezervacijuTerminaDto>().ToTable("ZahtevZaRezervacijuTermina");
		}

	}
}
