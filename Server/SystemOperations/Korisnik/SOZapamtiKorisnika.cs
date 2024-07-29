using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class SOZapamtiKorisnika : SOBase
    {
        Korisnik korisnik;
        public IEntity result;
        public SOZapamtiKorisnika(Korisnik korisnik)
        {
            this.korisnik = korisnik;
        }
        protected override void ExecuteConcreteOperation()
        {
            try
            {
                broker.Insert(korisnik);
                result = broker.GetEntityById(korisnik);
            }
            catch (Exception)
            {
                result = null;
            }
        }
    }
}
