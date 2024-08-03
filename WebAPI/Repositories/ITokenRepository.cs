using Common.Domain;
using Microsoft.AspNetCore.Identity;

namespace WebAPI.Repositories
{
	public interface ITokenRepository
	{
		string CreateJWTToken(Korisnik korisnik);
	}
}
