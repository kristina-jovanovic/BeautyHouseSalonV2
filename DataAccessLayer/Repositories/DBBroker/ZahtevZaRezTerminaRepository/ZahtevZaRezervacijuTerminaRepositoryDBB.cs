using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.DBBroker.ZahtevZaRezTerminaRepository
{
	public class ZahtevZaRezervacijuTerminaRepositoryDBB : IZahtevZaRezervacijuTerminaRepositoryDBB
	{
		private readonly Broker broker;

		public ZahtevZaRezervacijuTerminaRepositoryDBB(Broker broker)
        {
			this.broker = broker;
		}
        public async Task AddAsync(ZahtevZaRezervacijuTermina t)
		{
			await broker.InsertAsync(t);
		}

		public async Task DeleteAsync(ZahtevZaRezervacijuTermina t)
		{
			await broker.DeleteAsync(t);
		}

		public async Task<IEnumerable<ZahtevZaRezervacijuTermina>> GetAllAsync()
		{
			return (IEnumerable<ZahtevZaRezervacijuTermina>)await broker.ReadAllAsync(new ZahtevZaRezervacijuTermina());
		}

		public async Task<ZahtevZaRezervacijuTermina> GetByIdAsync(int id)
		{
			return (ZahtevZaRezervacijuTermina)await broker.GetEntityByIdAsync(new ZahtevZaRezervacijuTermina { ZahtevID = id });
		}

		public Task UpdateAsync(ZahtevZaRezervacijuTermina t)
		{
			return broker.UpdateAsync(t);
		}
	}
}
