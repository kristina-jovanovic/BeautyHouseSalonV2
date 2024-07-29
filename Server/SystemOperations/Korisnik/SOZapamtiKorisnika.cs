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
        protected override async Task ExecuteConcreteOperationAsync()
        {
            try
            {
                await broker.InsertAsync(korisnik);
                result = await broker.GetEntityByIdAsync(korisnik);
            }
            catch (Exception)
            {
                result = null;
            }
        }
    }
}
