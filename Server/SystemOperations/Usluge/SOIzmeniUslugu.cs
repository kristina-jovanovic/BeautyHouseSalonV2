using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class SOIzmeniUslugu : SOBase
    {
        internal IEntity result;
        private Usluga usluga;

        public SOIzmeniUslugu(Usluga usluga)
        {
            this.usluga = usluga;
        }

        protected override void ExecuteConcreteOperation()
        {
            try
            {
                broker.Update(usluga);
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
