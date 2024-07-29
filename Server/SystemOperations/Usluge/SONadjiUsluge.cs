using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class SONadjiUsluge : SOBase
    {
        private Usluga usluga;
        private string filter;
        public List<IEntity> result;

        public SONadjiUsluge(Usluga usluga, string filter)
        {
            this.usluga = usluga;
            this.filter = filter;
        }

        protected override async Task ExecuteConcreteOperationAsync()
        {
            result =await broker.ReadAllWithFilterAsync(usluga, filter);
        }
    }
}
