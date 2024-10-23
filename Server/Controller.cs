using Common.Domain;
using DataAccessLayer;
using DataAccessLayer.Repositories.DBBroker;
using DBBroker;
using Microsoft.Extensions.DependencyInjection;
using Server.Exceptions;
using Server.SystemOperations.KorisnikSO;
using Server.SystemOperations.ProfilRadnikaSO;
using Server.SystemOperations.TipUslugeSO;
using Server.SystemOperations.UslugaSO;
using Server.SystemOperations.ZahtevZaRezervacijuTerminaSO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
	public class Controller
	{
		private IRepository<IEntity> repository;
		public Controller(IRepository<IEntity> repository)
		{
			this.repository = repository;
		}

		public async Task<Korisnik> DodajKorisnikaAsync(Korisnik k)
		{
			SOZapamtiKorisnika so = new SOZapamtiKorisnika(repository, k);
			await so.ExecuteTemplateAsync();
			return (Korisnik)so.result;
		}

		public async Task<Korisnik> UlogujKorisnikaAsync(Korisnik k)
		{
			SOUlogujKorisnika so = new SOUlogujKorisnika(repository, k);
			await so.ExecuteTemplateAsync();
			if (so.pogresnaLozinka)
			{
				throw new WrongPasswordException();
			}
			return (Korisnik)so.result;
		}

		public async Task<List<TipUsluge>> UcitajListuTipovaUslugaAsync()
		{
			SOUcitajListuTipovaUsluga so = new SOUcitajListuTipovaUsluga(repository, new TipUsluge());
			await so.ExecuteTemplateAsync();
			return so.result.Cast<TipUsluge>().ToList();
		}

		public async Task<Usluga> KreirajNovuUsluguAsync(Usluga usluga)
		{
			SOKreirajUslugu so = new SOKreirajUslugu(repository, usluga);
			await so.ExecuteTemplateAsync();
			return (Usluga)so.result;
		}

		public async Task<List<Usluga>> UcitajListuUslugaAsync()
		{
			SOUcitajListuUsluga so = new SOUcitajListuUsluga(repository, new Usluga());
			await so.ExecuteTemplateAsync();
			return so.result.Cast<Usluga>().ToList();
		}

		public async Task<List<Usluga>> NadjiUslugeFilterAsync(string filter)
		{
			SONadjiUsluge so = new SONadjiUsluge(repository, new Usluga(), filter);
			await so.ExecuteTemplateAsync();
			return so.result.Cast<Usluga>().ToList();
		}

		public async Task<Usluga> UcitajUsluguAsync(Usluga usluga)
		{
			SOUcitajUslugu so = new SOUcitajUslugu(repository, usluga);
			await so.ExecuteTemplateAsync();
			return (Usluga)so.result;
		}

		public async Task<Usluga> IzmeniUsluguAsync(Usluga usluga)
		{
			SOIzmeniUslugu so = new SOIzmeniUslugu(repository, usluga);
			await so.ExecuteTemplateAsync();
			return (Usluga)so.result;
		}

		public async Task<bool> ObrisiUsluguAsync(Usluga usluga)
		{
			SOObrisiUslugu so = new SOObrisiUslugu(repository, usluga);
			await so.ExecuteTemplateAsync();
			return so.result;
		}

		public async Task<ProfilRadnika> KreirajProfilRadnikaAsync(ProfilRadnika radnik)
		{
			SOKreirajProfilRadnika so = new SOKreirajProfilRadnika(repository, radnik);
			await so.ExecuteTemplateAsync();
			return (ProfilRadnika)so.result;
		}

		public async Task<List<ProfilRadnika>> UcitajListuProfilaRadnikaAsync()
		{
			SOUcitajListuProfilaRadnika so = new SOUcitajListuProfilaRadnika(repository, new ProfilRadnika());
			await so.ExecuteTemplateAsync();
			return so.result.Cast<ProfilRadnika>().ToList();
		}

		public async Task<List<ProfilRadnika>> NadjiProfileRadnikaFilterAsync(string filter)
		{
			SONadjiProfileRadnika so = new SONadjiProfileRadnika(repository, new ProfilRadnika(), filter);
			await so.ExecuteTemplateAsync();
			return so.result.Cast<ProfilRadnika>().ToList();
		}

		public async Task<ProfilRadnika> UcitajProfilRadnikaAsync(ProfilRadnika radnik)
		{
			SOUcitajProfilRadnika so = new SOUcitajProfilRadnika(repository, radnik);
			await so.ExecuteTemplateAsync();
			return (ProfilRadnika)so.result;
		}
		public async Task<List<ZahtevZaRezervacijuTermina>> ProveriRaspolozivostTerminaAsync(ZahtevZaRezervacijuTermina zahtev)
		{
			SOProveriRaspolozivostTermina so = new SOProveriRaspolozivostTermina(repository, zahtev);
			await so.ExecuteTemplateAsync();
			return so.result.Cast<ZahtevZaRezervacijuTermina>().ToList();
		}
		public async Task<List<ZahtevZaRezervacijuTermina>> KreirajZahteveZaRezervacijuTerminaAsync(List<ZahtevZaRezervacijuTermina> zahtevi)
		{
			SOKreirajZahteveZaRezervacijuTermina so = new SOKreirajZahteveZaRezervacijuTermina(repository, zahtevi);
			await so.ExecuteTemplateAsync();
			return so.result.Cast<ZahtevZaRezervacijuTermina>().ToList();
		}
		public async Task<List<ZahtevZaRezervacijuTermina>> UcitajZahteveZaRezervacijuTerminaAsync(ZahtevZaRezervacijuTermina z)
		{
			SOUcitajListuZahtevaZaRezervacijuTermina so = new SOUcitajListuZahtevaZaRezervacijuTermina(repository, z);
			await so.ExecuteTemplateAsync();
			return so.result.Cast<ZahtevZaRezervacijuTermina>().ToList();
		}

		public async Task<List<ZahtevZaRezervacijuTermina>> NadjiZahteveZaRezervacijuTerminaAsync(ProfilRadnika r)
		{
			SONadjiZahteveZaRezervacijuTermina so = new SONadjiZahteveZaRezervacijuTermina(repository, new ZahtevZaRezervacijuTermina(), r);
			await so.ExecuteTemplateAsync();
			return so.result.Cast<ZahtevZaRezervacijuTermina>().ToList();
		}

		public async Task<List<ZahtevZaRezervacijuTermina>> ZakaziTermineAsync(List<ZahtevZaRezervacijuTermina> zahtevi, StatusZahteva status)
		{
			SOZakaziTermine so = new SOZakaziTermine(repository, zahtevi, status);
			await so.ExecuteTemplateAsync();
			return so.result.Cast<ZahtevZaRezervacijuTermina>().ToList();
		}

	}
}
