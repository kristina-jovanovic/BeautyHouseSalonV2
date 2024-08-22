using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.DBBroker.TipUslugeRepository
{
	public class TipUslugeRepositoryDBB : ITipUslugeRepositoryDBB
	{
		private readonly Broker broker;

		public TipUslugeRepositoryDBB(Broker broker)
        {
			this.broker = broker;
		}
        public async Task AddAsync(TipUsluge t)
		{
			await broker.InsertAsync(t);
		}

		public async Task DeleteAsync(TipUsluge t)
		{
			await broker.DeleteAsync(t);
		}

		public async Task<IEnumerable<TipUsluge>> GetAllAsync()
		{
			return (IEnumerable<TipUsluge>)await broker.ReadAllAsync(new TipUsluge());
		}

		public async Task<TipUsluge> GetByIdAsync(int id)
		{
			return (TipUsluge)await broker.GetEntityByIdAsync(new TipUsluge { TipUslugeID = id });
		}

		public async Task UpdateAsync(TipUsluge t)
		{
			await broker.UpdateAsync(t);
		}
	}
}
