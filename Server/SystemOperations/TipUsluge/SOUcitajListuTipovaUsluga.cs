using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.TipUsluge
{
    public class SOUcitajListuTipovaUsluga : SOBase
    {
        private Common.Domain.TipUsluge tipUsluge;
        public List<IEntity> result;

        public SOUcitajListuTipovaUsluga(Common.Domain.TipUsluge tipUsluge)
        {
            this.tipUsluge = tipUsluge;
        }

        protected override async Task ExecuteConcreteOperationAsync()
        {
            result = await broker.ReadAllAsync(tipUsluge);
        }
    }
}
