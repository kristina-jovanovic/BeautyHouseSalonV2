using Common.Domain;
using DBBroker;
using Server.Exceptions;
using Server.SystemOperations;
using Server.SystemOperations.ProfilRadnika;
using Server.SystemOperations.TipUsluge;
using Server.SystemOperations.Usluge;
using Server.SystemOperations.ZahtevZaRezervacijuTermina;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
	public class Controller
	{
		private static Controller instance;
		public static Controller Instance
		{
			get
			{
				if (instance == null) instance = new Controller();
				return instance;
			}
		}
		private Controller()
		{

		}

		public async Task<Korisnik> DodajKorisnikaAsync(Korisnik k)
		{
			SOZapamtiKorisnika so = new SOZapamtiKorisnika(k);
			await so.ExecuteTemplate();
			return (Korisnik)so.result;
		}

		public async Task<Korisnik> UlogujKorisnikaAsync(Korisnik k)
		{
			SOUlogujKorisnika so = new SOUlogujKorisnika(k);
			await so.ExecuteTemplate();
			if (so.pogresnaLozinka)
			{
				throw new WrongPasswordException();
			}
			return (Korisnik)so.result;
		}

		public async Task<List<TipUsluge>> UcitajListuTipovaUslugaAsync()
		{
			SOUcitajListuTipovaUsluga so = new SOUcitajListuTipovaUsluga(new TipUsluge());
			await so.ExecuteTemplate();
			return so.result.Cast<TipUsluge>().ToList();
		}

		public async Task<Usluga> KreirajNovuUsluguAsync(Usluga usluga)
		{
			SOKreirajUslugu so = new SOKreirajUslugu(usluga);
			await so.ExecuteTemplate();
			return (Usluga)so.result;
		}

		public async Task<List<Usluga>> UcitajListuUslugaAsync()
		{
			SOUcitajListuUsluga so = new SOUcitajListuUsluga(new Usluga());
			await so.ExecuteTemplate();
			return so.result.Cast<Usluga>().ToList();
		}

		public async Task<List<Usluga>> NadjiUslugeFilterAsync(string filter)
		{
			SONadjiUsluge so = new SONadjiUsluge(new Usluga(), filter);
			await so.ExecuteTemplate();
			return so.result.Cast<Usluga>().ToList();
		}

		public async Task<Usluga> UcitajUsluguAsync(Usluga usluga)
		{
			SOUcitajUslugu so = new SOUcitajUslugu(usluga);
			await so.ExecuteTemplate();
			return (Usluga)so.result;
		}

		public async Task<Usluga> IzmeniUsluguAsync(Usluga usluga)
		{
			SOIzmeniUslugu so = new SOIzmeniUslugu(usluga);
			await so.ExecuteTemplate();
			return (Usluga)so.result;
		}

		public async Task<bool> ObrisiUsluguAsync(Usluga usluga)
		{
			SOObrisiUslugu so = new SOObrisiUslugu(usluga);
			await so.ExecuteTemplate();
			return so.result;
		}

		public async Task<ProfilRadnika> KreirajProfilRadnikaAsync(ProfilRadnika radnik)
		{
			SOKreirajProfilRadnika so = new SOKreirajProfilRadnika(radnik);
			await so.ExecuteTemplate();
			return (ProfilRadnika)so.result;
		}

		public async Task<List<ProfilRadnika>> UcitajListuProfilaRadnikaAsync()
		{
			SOUcitajListuProfilaRadnika so = new SOUcitajListuProfilaRadnika(new ProfilRadnika());
			await so.ExecuteTemplate();
			return so.result.Cast<ProfilRadnika>().ToList();
		}

		public async Task<List<ProfilRadnika>> NadjiProfileRadnikaFilterAsync(string filter)
		{
			SONadjiProfileRadnika so = new SONadjiProfileRadnika(new ProfilRadnika(), filter);
			await so.ExecuteTemplate();
			return so.result.Cast<ProfilRadnika>().ToList();
		}

		public async Task<ProfilRadnika> UcitajProfilRadnikaAsync(ProfilRadnika radnik)
		{
			SOUcitajProfilRadnika so = new SOUcitajProfilRadnika(radnik);
			await so.ExecuteTemplate();
			return (ProfilRadnika)so.result;
		}
		public async Task<List<ZahtevZaRezervacijuTermina>> ProveriRaspolozivostTerminaAsync(ZahtevZaRezervacijuTermina zahtev)
		{
			SOProveriRaspolozivostTermina so = new SOProveriRaspolozivostTermina(zahtev);
			await so.ExecuteTemplate();
			return so.result.Cast<ZahtevZaRezervacijuTermina>().ToList();
		}
		public async Task<List<ZahtevZaRezervacijuTermina>> KreirajZahteveZaRezervacijuTerminaAsync(List<ZahtevZaRezervacijuTermina> zahtevi)
		{
			SOKreirajZahteveZaRezervacijuTermina so = new SOKreirajZahteveZaRezervacijuTermina(zahtevi);
			await so.ExecuteTemplate();
			return so.result.Cast<ZahtevZaRezervacijuTermina>().ToList();
		}
		public async Task<List<ZahtevZaRezervacijuTermina>> UcitajZahteveZaRezervacijuTerminaAsync(ZahtevZaRezervacijuTermina z)
		{
			SOUcitajListuZahtevaZaRezervacijuTermina so = new SOUcitajListuZahtevaZaRezervacijuTermina(z);
			await so.ExecuteTemplate();
			return so.result.Cast<ZahtevZaRezervacijuTermina>().ToList();
		}

		public async Task<List<ZahtevZaRezervacijuTermina>> NadjiZahteveZaRezervacijuTerminaAsync(ProfilRadnika r)
		{
			SONadjiZahteveZaRezervacijuTermina so = new SONadjiZahteveZaRezervacijuTermina(new ZahtevZaRezervacijuTermina(), r);
			await so.ExecuteTemplate();
			return so.result.Cast<ZahtevZaRezervacijuTermina>().ToList();
		}

		public async Task<List<ZahtevZaRezervacijuTermina>> ZakaziTermineAsync(List<ZahtevZaRezervacijuTermina> zahtevi, StatusZahteva status)
		{
			SOZakaziTermine so = new SOZakaziTermine(zahtevi, status);
			await so.ExecuteTemplate();
			return so.result.Cast<ZahtevZaRezervacijuTermina>().ToList();
		}

	}
}
