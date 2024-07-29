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

        public Korisnik DodajKorisnika(Korisnik k)
        {
            SOZapamtiKorisnika so = new SOZapamtiKorisnika(k);
            so.ExecuteTemplate();
            return (Korisnik)so.result;
        }

        public Korisnik UlogujKorisnika(Korisnik k)
        {
            SOUlogujKorisnika so = new SOUlogujKorisnika(k);
            so.ExecuteTemplate();
            if (so.pogresnaLozinka)
            {
                throw new WrongPasswordException();
            }
            return (Korisnik)so.result;
        }

        public List<TipUsluge> UcitajListuTipovaUsluga()
        {
            SOUcitajListuTipovaUsluga so = new SOUcitajListuTipovaUsluga(new TipUsluge());
            so.ExecuteTemplate();
            return so.result.Cast<TipUsluge>().ToList();
        }

        public Usluga KreirajNovuUslugu(Usluga usluga)
        {
            SOKreirajUslugu so = new SOKreirajUslugu(usluga);
            so.ExecuteTemplate();
            return (Usluga)so.result;
        }

        public List<Usluga> UcitajListuUsluga()
        {
            SOUcitajListuUsluga so = new SOUcitajListuUsluga(new Usluga());
            so.ExecuteTemplate();
            return so.result.Cast<Usluga>().ToList();
        }

        public List<Usluga> NadjiUslugeFilter(string filter)
        {
            SONadjiUsluge so = new SONadjiUsluge(new Usluga(), filter);
            so.ExecuteTemplate();
            return so.result.Cast<Usluga>().ToList();
        }

        public Usluga UcitajUslugu(Usluga usluga)
        {
            SOUcitajUslugu so = new SOUcitajUslugu(usluga);
            so.ExecuteTemplate();
            return (Usluga)so.result;
        }

        public Usluga IzmeniUslugu(Usluga usluga)
        {
            SOIzmeniUslugu so = new SOIzmeniUslugu(usluga);
            so.ExecuteTemplate();
            return (Usluga)so.result;
        }

        public bool ObrisiUslugu(Usluga usluga)
        {
            SOObrisiUslugu so = new SOObrisiUslugu(usluga);
            so.ExecuteTemplate();
            return so.result;
        }

        public ProfilRadnika KreirajProfilRadnika(ProfilRadnika radnik)
        {
            SOKreirajProfilRadnika so = new SOKreirajProfilRadnika(radnik);
            so.ExecuteTemplate() ;
            return (ProfilRadnika)so.result;
        }

        public List<ProfilRadnika> UcitajListuProfilaRadnika()
        {
            SOUcitajListuProfilaRadnika so = new SOUcitajListuProfilaRadnika(new ProfilRadnika());
            so.ExecuteTemplate();
            return so.result.Cast<ProfilRadnika>().ToList();
        }

        public List<ProfilRadnika> NadjiProfileRadnikaFilter(string filter)
        {
            SONadjiProfileRadnika so = new SONadjiProfileRadnika(new ProfilRadnika(), filter);
            so.ExecuteTemplate();
            return so.result.Cast<ProfilRadnika>().ToList();
        }

        public ProfilRadnika UcitajProfilRadnika(ProfilRadnika radnik)
        {
            SOUcitajProfilRadnika so = new SOUcitajProfilRadnika(radnik);
            so.ExecuteTemplate();
            return (ProfilRadnika)so.result;
        }
        public List<ZahtevZaRezervacijuTermina> ProveriRaspolozivostTermina(ZahtevZaRezervacijuTermina zahtev)
        {
            SOProveriRaspolozivostTermina so = new SOProveriRaspolozivostTermina(zahtev);
            so.ExecuteTemplate();
            return so.result.Cast<ZahtevZaRezervacijuTermina>().ToList();
        }
        public List<ZahtevZaRezervacijuTermina> KreirajZahteveZaRezervacijuTermina(List<ZahtevZaRezervacijuTermina> zahtevi)
        {
            SOKreirajZahteveZaRezervacijuTermina so = new SOKreirajZahteveZaRezervacijuTermina(zahtevi);
            so.ExecuteTemplate();
            return so.result.Cast<ZahtevZaRezervacijuTermina>().ToList();
        }
        public List<ZahtevZaRezervacijuTermina> UcitajZahteveZaRezervacijuTermina(ZahtevZaRezervacijuTermina z)
        {
            SOUcitajListuZahtevaZaRezervacijuTermina so = new SOUcitajListuZahtevaZaRezervacijuTermina(z);
            so.ExecuteTemplate();
            return so.result.Cast<ZahtevZaRezervacijuTermina>().ToList();
        }

        public List<ZahtevZaRezervacijuTermina> NadjiZahteveZaRezervacijuTermina(ProfilRadnika r)
        {
            SONadjiZahteveZaRezervacijuTermina so = new SONadjiZahteveZaRezervacijuTermina(new ZahtevZaRezervacijuTermina(),r);
            so.ExecuteTemplate();
            return so.result.Cast<ZahtevZaRezervacijuTermina>().ToList();
        }

        public List<ZahtevZaRezervacijuTermina> ZakaziTermine(List<ZahtevZaRezervacijuTermina> zahtevi, StatusZahteva status)
        {
            SOZakaziTermine so = new SOZakaziTermine(zahtevi,status);
            so.ExecuteTemplate();
            return so.result.Cast<ZahtevZaRezervacijuTermina>().ToList();
        }

    }
}
