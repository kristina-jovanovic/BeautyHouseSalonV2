using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class SOKreirajUslugu : SOBase
    {
        private Usluga usluga;
        public IEntity result;

        public SOKreirajUslugu(Usluga usluga)
        {
            this.usluga = usluga;
        }

        protected override async Task ExecuteConcreteOperationAsync()
        {
            try
            {
                await broker.InsertAsync(usluga);
                result = await broker.GetEntityByIdAsync(usluga);
            }
            catch (Exception)
            {
                //unique ogranicenje je naruseno, vec postoji usluga sa tim nazivom u bazi
                result = null;
            }
        }
    }
}
