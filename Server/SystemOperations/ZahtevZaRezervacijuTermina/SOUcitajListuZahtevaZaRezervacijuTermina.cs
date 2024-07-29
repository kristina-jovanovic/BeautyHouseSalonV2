using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ZahtevZaRezervacijuTermina
{
    internal class SOUcitajListuZahtevaZaRezervacijuTermina : SOBase
    {
        private Common.Domain.ZahtevZaRezervacijuTermina z;
        public List<IEntity> result;
        public SOUcitajListuZahtevaZaRezervacijuTermina(Common.Domain.ZahtevZaRezervacijuTermina z)
        {
            this.z = z;
        }

        protected override void ExecuteConcreteOperation()
        {
            result = broker.GetEntitiesById(z,StatusZahteva.NaCekanju);
        }
    }
}
