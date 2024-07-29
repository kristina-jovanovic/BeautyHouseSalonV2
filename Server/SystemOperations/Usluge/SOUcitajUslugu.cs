using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.Usluge
{
    internal class SOUcitajUslugu : SOBase
    {
        internal IEntity result;
        private Usluga usluga;

        public SOUcitajUslugu(Usluga usluga)
        {
            this.usluga = usluga;
        }

        protected override void ExecuteConcreteOperation()
        {
            result = broker.GetEntityById(usluga);
        }
    }
}
