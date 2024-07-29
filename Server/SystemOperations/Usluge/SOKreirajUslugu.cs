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

        protected override void ExecuteConcreteOperation()
        {
            try
            {
                broker.Insert(usluga);
                result = broker.GetEntityById(usluga);
            }
            catch (Exception)
            {
                //unique ogranicenje je naruseno, vec postoji usluga sa tim nazivom u bazi
                result = null;
            }
        }
    }
}
