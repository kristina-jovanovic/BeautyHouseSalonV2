using AutoMapper;
using Common.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TerminiController : ControllerBase
	{
		private readonly IMapper mapper;

		public TerminiController(IMapper mapper)
        {
			this.mapper = mapper;
		}

		//[HttpGet]
		//public async Task<IActionResult> GetAll()
		//{
		//	List<ZahtevZaRezervacijuTermina> zahtevi = await Server.Controller.Instance.UcitajZahteveZaRezervacijuTerminaAsync();
		//}
    }
}
