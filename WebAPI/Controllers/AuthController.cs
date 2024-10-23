using AutoMapper;
using Common.Domain;
using Common.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using WebAPI.Repositories;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IMapper mapper;
		private readonly ITokenRepository tokenRepository;
		private readonly Server.Controller controller;

		public AuthController(IMapper mapper, ITokenRepository tokenRepository, Server.Controller controller)
		{
			this.mapper = mapper;
			this.tokenRepository = tokenRepository;
			this.controller = controller;
		}

		[HttpPost]
		[Route("Register")]
		public async Task<IActionResult> Register([FromBody] KorisnikDto korisnikDto)
		{
			Korisnik korisnik = mapper.Map<Korisnik>(korisnikDto);

			byte[] salt = HashFunction.GenerateCode();
			korisnik.KodZaEnkripciju = Convert.ToBase64String(salt);
			//na osnovu ovog salta tj. koda za enkripciju cemo kasnije i prilikom logina proveravati ispravnost unete lozinke (to je implementirano 
			//na serverskoj strani u UlogujKorisnikaAsync(korisnik) i metodama koje ta metoda koristi
			korisnik.Lozinka = HashFunction.HashPassword(korisnik.Lozinka, salt);
			//u metodu se salje lozinka u formatu u kom ju je korisnik uneo, a vraca se
			//hashovana lozinka i upisuje u property Lozinka

			korisnik = await controller.DodajKorisnikaAsync(korisnik);
			if (korisnik == null)
			{
				//ako vrati null znaci da je korisnicko ime zauzeto i da ne moze da kreira novi korisnicki nalog
				return Ok(new { Success = false, Message = "Korisnicko ime koje ste uneli je zauzeto. Pokusajte ponovo." });
			}
			//napravi token i vrati ga
			var jwtToken = tokenRepository.CreateJWTToken(korisnik);
			return Ok(new { Success = true, User = mapper.Map<KorisnikDto>(korisnik), JwtToken = jwtToken });
		}

		[HttpPost]
		[Route("Login")]
		public async Task<IActionResult> Login([FromBody] KorisnikDto korisnikDto)
		{
			Korisnik korisnik = new Korisnik
			{
				KorisnickoIme = korisnikDto.KorisnickoIme,
				Lozinka = korisnikDto.Lozinka
			};
			try
			{
				korisnik = await controller.UlogujKorisnikaAsync(korisnik);
				//provera hashovane lozinke je implementirana unutar ove metode i metoda koje ona koristi, tako da nema potrebe ovde da proveravamo
			}
			catch (Server.Exceptions.WrongPasswordException)
			{
				return Ok(new { Success = false, Message = "Uneli ste pogresnu lozinku za uneto korisnicko ime. Pokusajte ponovo." });
			}
			if (korisnik == null)
			{
				return Ok(new { Success = false, Message = "Korisnik sa unetim korisnickim imenom ne postoji. Pokusajte ponovo." });
			}
			if (korisnik.Vlasnik)
			{
				return Ok(new { Success = false, Message = "Ova aplikacija je namenjena samo klijentima. Vlasnici se prijavljuju na desktop aplikaciju." });
			}
			//napravi token i vrati ga
			var jwtToken = tokenRepository.CreateJWTToken(korisnik);
			return Ok(new { Success = true, User = mapper.Map<KorisnikDto>(korisnik), JwtToken = jwtToken });
		}
	}
}
