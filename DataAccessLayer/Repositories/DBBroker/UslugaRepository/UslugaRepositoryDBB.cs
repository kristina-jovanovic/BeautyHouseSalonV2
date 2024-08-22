using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.DBBroker.UslugaRepository
{
	public class UslugaRepositoryDBB : IUslugaRepositoryDBB
	{
		private readonly Broker broker;

		public UslugaRepositoryDBB(Broker broker)
        {
			this.broker = broker;
		}
        public async Task AddAsync(Usluga t)
		{
			await broker.InsertAsync(t);
		}

		public async Task DeleteAsync(Usluga t)
		{
			await broker.DeleteAsync(t);
		}

		public async Task<IEnumerable<Usluga>> GetAllAsync()
		{
			return (IEnumerable<Usluga>)await broker.ReadAllAsync(new Usluga());
		}

		public async Task<Usluga> GetByIdAsync(int id)
		{
			return (Usluga)await broker.GetEntityByIdAsync(new Usluga { UslugaID = id });
		}

		public async Task UpdateAsync(Usluga t)
		{
			await broker.UpdateAsync(t);
		}
	}
}
