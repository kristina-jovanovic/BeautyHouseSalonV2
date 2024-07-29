using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.Usluge
{
    internal class SOObrisiUslugu : SOBase
    {
        public bool result;
        private Usluga usluga;

        public SOObrisiUslugu(Usluga usluga)
        {
            this.usluga = usluga;
        }

        protected override async Task ExecuteConcreteOperationAsync()
        {
            try
            {
                await broker.DeleteAsync(usluga);
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
        }
    }
}
