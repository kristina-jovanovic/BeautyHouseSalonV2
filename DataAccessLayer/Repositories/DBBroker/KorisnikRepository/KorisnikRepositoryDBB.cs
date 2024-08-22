using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.DBBroker.KorisnikRepository
{
	public class KorisnikRepositoryDBB : IKorisnikRepositoryDBB
	{
		private readonly Broker broker;

		public KorisnikRepositoryDBB(Broker broker)
		{
			this.broker = broker;
		}
		public async Task AddAsync(Korisnik t)
		{
			await broker.InsertAsync(t);
		}

		public async Task DeleteAsync(Korisnik t)
		{
			await broker.DeleteAsync(t);
		}

		public async Task<IEnumerable<Korisnik>> GetAllAsync()
		{
			return (IEnumerable<Korisnik>)await broker.ReadAllAsync(new Korisnik());
		}

		public async Task<Korisnik> GetByIdAsync(int id)
		{
			return (Korisnik)await broker.GetEntityByIdAsync(new Korisnik { KorisnikID = id });
		}

		public async Task UpdateAsync(Korisnik t)
		{
			await broker.UpdateAsync(t);
		}
	}
}
