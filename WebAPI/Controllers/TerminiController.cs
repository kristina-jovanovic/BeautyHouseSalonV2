using AutoMapper;
using Common.Communication;
using Common.Domain;
using Common.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TerminiController : ControllerBase
	{
		private readonly IMapper mapper;
		private readonly EmailSender emailSender;

		public TerminiController(IMapper mapper, EmailSender emailSender)
		{
			this.mapper = mapper;
			this.emailSender = emailSender;
		}

		[HttpGet]
		[Route("{ime}-{prezime}")]
		public async Task<IActionResult> GetAllByWorker([FromRoute] string ime, [FromRoute] string prezime)
		{
			ProfilRadnika radnik = new ProfilRadnika
			{
				Ime = ime,
				Prezime = prezime
			};
			List<ZahtevZaRezervacijuTermina> zahtevi = await Server.Controller.Instance.NadjiZahteveZaRezervacijuTerminaAsync(radnik);
			if (zahtevi == null || zahtevi.Count == 0)
			{
				return NotFound();
			}
			return Ok(mapper.Map<List<ZahtevZaRezervacijuTerminaDto>>(zahtevi));

			//ovo je kad izaberem radnika i vreme i treba da se vrate zahtevi koji su na cekanju - ovo sam napisala al nisam ni koristila ? 
			//List<ZahtevZaRezervacijuTermina> zahtevi = await Server.Controller.Instance.UcitajZahteveZaRezervacijuTerminaAsync(new ZahtevZaRezervacijuTermina());
			//if (zahtevi == null)
			//{
			//	return NotFound();
			//}
			//return Ok(mapper.Map<List<ZahtevZaRezervacijuTerminaDto>>(zahtevi));
		}

		[HttpPost]
		[Authorize]
		public async Task<IActionResult> Create([FromBody] List<ZahtevZaRezervacijuTermina> zahteviDto)
		{
			//datum kad se salje mora u ovom formatu "yyyy-MM-ddTHH:mm:ss.fffZ" (za JSON)
			List<ZahtevZaRezervacijuTermina> zahtevi = mapper.Map<List<ZahtevZaRezervacijuTermina>>(zahteviDto);
			zahtevi = await Server.Controller.Instance.KreirajZahteveZaRezervacijuTerminaAsync(zahtevi);
			if (zahtevi == null || zahtevi.Count == 0)
			{
				return Ok(new {Success=false});
			}
			emailSender.SendEmail(zahtevi, StatusZahteva.NaCekanju);
			return Ok(new { Success=true, Termini=mapper.Map<List<ZahtevZaRezervacijuTerminaDto>>(zahtevi) } );
		}
		[HttpPost]
		[Route("proveri-raspolozivost")]
		[Authorize]
		public async Task<bool> CheckAvailability([FromBody] ZahtevZaRezervacijuTerminaDto zahtevDto)
		{
			//bitno je da se popuni datum i vreme termina i id radnika
			ZahtevZaRezervacijuTermina zahtev = mapper.Map<ZahtevZaRezervacijuTermina>(zahtevDto);
			List<ZahtevZaRezervacijuTermina> zahtevi = await Server.Controller.Instance.ProveriRaspolozivostTerminaAsync(zahtev);
			if (zahtevi.Count != 0)
			{
				//postoji bar jedan zahtev kod tog radnika u to vreme koji je odobren = nije slobodan termin
				return false;
			}
			else
			{
				//slobodan termin za sada, mozda postoji neki na cekanju ali nije odobren jos uvek
				return true;
			}
		}

		[HttpPost]
		[Route("zakazi-termine")]
		public async Task<IActionResult> Accept([FromBody] List<ZahtevZaRezervacijuTerminaDto> zahteviDto, [FromQuery] bool odobreni)
		{
			//datum kad se salje mora u ovom formatu "yyyy-MM-ddTHH:mm:ss.fffZ" (za JSON)
			//bitno je upisati ZahtevId, VremeKreiranja i KorisnikID
			List<ZahtevZaRezervacijuTermina> zahtevi = mapper.Map<List<ZahtevZaRezervacijuTermina>>(zahteviDto);
			if (odobreni)
			{
				zahtevi = await Server.Controller.Instance.ZakaziTermineAsync(zahtevi, StatusZahteva.Odobren);
			}
			else
			{
				zahtevi = await Server.Controller.Instance.ZakaziTermineAsync(zahtevi, StatusZahteva.Odbijen);
			}
			if (zahtevi == null || zahtevi.Count == 0)
			{
				return BadRequest();
			}
			return Ok(mapper.Map<List<ZahtevZaRezervacijuTerminaDto>>(zahtevi));
		}

	}
}
