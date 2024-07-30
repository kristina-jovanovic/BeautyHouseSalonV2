using Common.Domain;
using Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UslugeController : ControllerBase
	{
		[HttpPost]
		public async Task<IActionResult> Create([FromBody] Usluga usluga)
		{
			Usluga u = await Server.Controller.Instance.KreirajNovuUsluguAsync(usluga);
			//vrati nesto smislenije
			//return Ok(u.ToString());
			return Created();

		}
	}
}
