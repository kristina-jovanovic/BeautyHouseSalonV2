using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ProfilRadnika
{
    internal class SONadjiProfileRadnika : SOBase
    {
        private Common.Domain.ProfilRadnika profilRadnika;
        private string filter;
        public List<IEntity> result;

        public SONadjiProfileRadnika(Common.Domain.ProfilRadnika profilRadnika, string filter)
        {
            this.profilRadnika = profilRadnika;
            this.filter = filter;
        }

        protected override void ExecuteConcreteOperation()
        {
            result = broker.ReadAllWithFilter(profilRadnika, filter);
        }
    }
}
