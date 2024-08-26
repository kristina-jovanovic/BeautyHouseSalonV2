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
		private readonly Server.Controller controller;

		public TipoviUslugaController(IMapper mapper,Server.Controller controller)
		{
			this.mapper = mapper;
			this.controller = controller;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			List<TipUsluge> tipoviUsluga = await controller.UcitajListuTipovaUslugaAsync();
			if (tipoviUsluga == null)
			{
				return NotFound();
			}
			return Ok(mapper.Map<List<TipUslugeDto>>(tipoviUsluga));
		}
	}
}
