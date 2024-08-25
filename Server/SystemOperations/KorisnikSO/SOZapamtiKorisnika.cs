using Common.Domain;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.KorisnikSO
{
	internal class SOZapamtiKorisnika : SOBase
	{
		Korisnik korisnik;
		public IEntity result;
		public SOZapamtiKorisnika(IRepository<IEntity> repository, Korisnik korisnik) : base(repository)
		{
			this.korisnik = korisnik;
		}
		protected override async Task ExecuteConcreteOperationAsync()
		{
			try
			{
				await repository.AddAsync(korisnik);
				result = await repository.GetByIdAsync(korisnik);
			}
			catch (Exception)
			{
				result = null;
			}
		}
	}
}
