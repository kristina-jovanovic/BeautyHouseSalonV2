using Common.Domain;
using Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Common.DTOs;
using System.Drawing.Drawing2D;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UslugeController : ControllerBase
	{
		private readonly IMapper mapper;

		public UslugeController(IMapper mapper)
		{
			this.mapper = mapper;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			List<Usluga> usluge = await Server.Controller.Instance.UcitajListuUslugaAsync();
			return Ok(mapper.Map<List<UslugaDto>>(usluge));
		}

		[HttpGet]
		[Route("{id:int}")]
		public async Task<IActionResult> GetById([FromRoute] int id)
		{
			Usluga usluga = await Server.Controller.Instance.UcitajUsluguAsync(new Usluga { UslugaID = id });
			return Ok(mapper.Map<UslugaDto>(usluga));
		}

		[HttpPost]
		public async Task<IActionResult> Create([FromBody] UslugaDto uslugaDto)
		{
			Usluga usluga = mapper.Map<Usluga>(uslugaDto);
			usluga = await Server.Controller.Instance.KreirajNovuUsluguAsync(usluga);
			uslugaDto = mapper.Map<UslugaDto>(usluga);
			return CreatedAtAction(nameof(GetById), new { id = uslugaDto.UslugaID }, uslugaDto);
		}
	}
}
