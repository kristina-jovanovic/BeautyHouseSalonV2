using AutoMapper;
using Common.Domain;
using Common.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TipoviUslugaController : ControllerBase
	{
		private readonly IMapper mapper;

		public TipoviUslugaController(IMapper mapper)
		{
			this.mapper = mapper;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			List<TipUsluge> tipoviUsluga = await Server.Controller.Instance.UcitajListuTipovaUslugaAsync();
			if (tipoviUsluga == null)
			{
				return NotFound();
			}
			return Ok(mapper.Map<List<TipUslugeDto>>(tipoviUsluga));
		}
	}
}
