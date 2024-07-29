using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.Usluge
{
    internal class SOUcitajListuUsluga : SOBase
    {
        internal List<IEntity> result;
        private Usluga usluga;

        public SOUcitajListuUsluga(Usluga usluga)
        {
            this.usluga = usluga;
        }

        protected override async Task ExecuteConcreteOperationAsync()
        {
            result = await broker.ReadAllAsync(usluga);
        }
    }
}
