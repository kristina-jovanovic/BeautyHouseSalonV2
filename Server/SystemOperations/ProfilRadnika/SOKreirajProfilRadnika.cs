using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ProfilRadnika
{
    internal class SOKreirajProfilRadnika : SOBase
    {
        internal IEntity result;
        private Common.Domain.ProfilRadnika radnik;

        public SOKreirajProfilRadnika(Common.Domain.ProfilRadnika radnik)
        {
            this.radnik = radnik;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Insert(radnik);
            result = broker.GetEntityById(radnik);
        }
    }
}
