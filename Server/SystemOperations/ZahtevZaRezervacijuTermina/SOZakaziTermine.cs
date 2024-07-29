using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ZahtevZaRezervacijuTermina
{
    internal class SOZakaziTermine : SOBase
    {
        public List<IEntity> result;
        private List<Common.Domain.ZahtevZaRezervacijuTermina> zahtevi;
        private StatusZahteva status;

        public SOZakaziTermine(List<Common.Domain.ZahtevZaRezervacijuTermina> zahtevi, StatusZahteva status)
        {
            this.zahtevi = zahtevi;
            this.status = status;
            result = new List<IEntity>();
        }

        protected override void ExecuteConcreteOperation()
        {
            foreach (Common.Domain.ZahtevZaRezervacijuTermina zahtev in zahtevi)
            {
                zahtev.StatusZahteva = status;
                broker.Update(zahtev);
                result.Add(broker.GetEntityById(zahtev));
            }
        }
    }
}
