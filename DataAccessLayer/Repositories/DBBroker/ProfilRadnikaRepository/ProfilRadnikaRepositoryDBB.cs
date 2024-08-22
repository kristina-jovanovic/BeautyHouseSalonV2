using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.DBBroker.ProfilRadnikaRepository
{
	public class ProfilRadnikaRepositoryDBB : IProfilRadnikaRepositoryDBB
	{
		private readonly Broker broker;

		public ProfilRadnikaRepositoryDBB(Broker broker)
        {
			this.broker = broker;
		}
        public async Task AddAsync(ProfilRadnika t)
		{
			await broker.InsertAsync(t);
		}

		public async Task DeleteAsync(ProfilRadnika t)
		{
			await broker.DeleteAsync(t);
		}

		public async Task<IEnumerable<ProfilRadnika>> GetAllAsync()
		{
			return (IEnumerable<ProfilRadnika>)await broker.ReadAllAsync(new ProfilRadnika());
		}

		public async Task<ProfilRadnika> GetByIdAsync(int id)
		{
			return (ProfilRadnika)await broker.GetEntityByIdAsync(new ProfilRadnika { RadnikID = id });
		}

		public async Task UpdateAsync(ProfilRadnika t)
		{
			await broker.UpdateAsync(t);
		}
	}
}
