using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ProfilRadnika
{
    internal class SOUcitajProfilRadnika :SOBase
    {
        private Common.Domain.ProfilRadnika radnik;
        public IEntity result;
        public SOUcitajProfilRadnika(Common.Domain.ProfilRadnika radnik)
        {
            this.radnik = radnik;
        }

        protected override async Task ExecuteConcreteOperationAsync()
        {
            result = await broker.GetEntityByIdAsync(radnik);
        }
    }
}
