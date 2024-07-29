using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ZahtevZaRezervacijuTermina
{
    internal class SONadjiZahteveZaRezervacijuTermina : SOBase
    {
        private Common.Domain.ProfilRadnika r;
        Common.Domain.ZahtevZaRezervacijuTermina zahtevZaRezervacijuTermina;
        public List<IEntity> result;

        public SONadjiZahteveZaRezervacijuTermina(Common.Domain.ZahtevZaRezervacijuTermina zahtevZaRezervacijuTermina, Common.Domain.ProfilRadnika r)
        {
            this.r = r;
            this.zahtevZaRezervacijuTermina = zahtevZaRezervacijuTermina;
        }

        protected override void ExecuteConcreteOperation()
        {
            result = broker.ReadAllWithFilter(zahtevZaRezervacijuTermina, $"{r.Ime} {r.Prezime}");
        }
    }
}
