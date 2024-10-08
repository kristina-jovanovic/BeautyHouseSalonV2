﻿using Common.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Common.DTOs;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UslugeController : ControllerBase
	{
		private readonly IMapper mapper;
		private readonly Server.Controller controller;

		public UslugeController(IMapper mapper,Server.Controller controller)
		{
			this.mapper = mapper;
			this.controller = controller;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll([FromQuery] string? filterQuery)
		{
			List<Usluga> usluge;
			if (string.IsNullOrEmpty(filterQuery))
			{
				usluge = await controller.UcitajListuUslugaAsync();
			}
			else
			{
				//u brokeru je implementirano tako da trazi usluge gde naziv usluge ili naziv tipa te usluge odgovaraju unetom filteru
				usluge = await controller.NadjiUslugeFilterAsync(filterQuery);
			}
			if (usluge == null || usluge.Count == 0)
			{
				return Ok(new { NotFound = true, Usluge= mapper.Map<List<UslugaDto>>(usluge) });
			}
			return Ok(mapper.Map<List<UslugaDto>>(usluge));
		}

		[HttpGet]
		[Route("{id:int}")]
		public async Task<IActionResult> GetById([FromRoute] int id)
		{
			Usluga usluga = await controller.UcitajUsluguAsync(new Usluga { UslugaID = id });
			if (usluga == null)
			{
				return NotFound();
			}
			return Ok(mapper.Map<UslugaDto>(usluga));
		}

		[HttpPost]
		public async Task<IActionResult> Create([FromBody] UslugaDto uslugaDto)
		{
			Usluga usluga = mapper.Map<Usluga>(uslugaDto);
			usluga = await controller.KreirajNovuUsluguAsync(usluga);
			if (usluga == null)
			{
				return BadRequest();
			}
			uslugaDto = mapper.Map<UslugaDto>(usluga);
			return CreatedAtAction(nameof(GetById), new { id = uslugaDto.UslugaID }, uslugaDto);
		}

		[HttpPut]
		[Route("{id:int}")]
		public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UslugaDto uslugaDto)
		{
			uslugaDto.UslugaID = id;
			Usluga usluga = mapper.Map<Usluga>(uslugaDto);
			usluga = await controller.IzmeniUsluguAsync(usluga);
			if (usluga == null)
			{
				return BadRequest();
			}
			uslugaDto = mapper.Map<UslugaDto>(usluga);
			return Ok(uslugaDto);
		}

		[HttpDelete]
		[Route("{id:int}")]
		public async Task<IActionResult> Delete([FromRoute] int id)
		{
			bool obrisano = await controller.ObrisiUsluguAsync(new Usluga { UslugaID = id });
			if (obrisano)
			{
				return Ok(obrisano);
			}
			return NotFound();
		}

	}
}
