using AutoMapper;
using Common.Domain;
using Common.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RadniciController : ControllerBase
	{
		private readonly IMapper mapper;
		private readonly Server.Controller controller;

		public RadniciController(IMapper mapper, Server.Controller controller)
		{
			this.mapper = mapper;
			this.controller = controller;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll([FromQuery] string? filterQuery)
		{
			List<ProfilRadnika> radnici;
			if (string.IsNullOrEmpty(filterQuery))
			{
				radnici = await controller.UcitajListuProfilaRadnikaAsync();
			}
			else
			{
				//trazi radnike kojima ime, prezime ili tip usluge odgovaraju poslatom filteru
				radnici = await controller.NadjiProfileRadnikaFilterAsync(filterQuery);
			}
			if (radnici == null)
			{
				return NotFound();
			}
			return Ok(mapper.Map<List<ProfilRadnikaDto>>(radnici));
		}

		[HttpGet]
		[Route("{id:int}")]
		public async Task<IActionResult> GetById([FromRoute] int id)
		{
			ProfilRadnika radnik = await controller.UcitajProfilRadnikaAsync(new ProfilRadnika { RadnikID = id });
			if (radnik == null)
			{
				return NotFound();
			}
			return Ok(mapper.Map<ProfilRadnikaDto>(radnik));
		}

		[HttpPost]
		public async Task<IActionResult> Create([FromBody] ProfilRadnikaDto radnikDto)
		{
			ProfilRadnika radnik = mapper.Map<ProfilRadnika>(radnikDto);
			radnik = await controller.KreirajProfilRadnikaAsync(radnik);
			if (radnik == null)
			{
				return BadRequest();
			}
			radnikDto = mapper.Map<ProfilRadnikaDto>(radnik);
			return CreatedAtAction(nameof(GetById), new { id = radnikDto.RadnikID }, radnikDto);
		}
	}
}
