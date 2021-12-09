using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CamSanctuaryRest.Managers;
using CamSanctuaryRest.Models;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CamSanctuaryRest.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SenderController : ControllerBase
	{
		private readonly SenderManager _manager;

		public SenderController(CamsanctuarydbContext context)
		{
			_manager = new SenderManager(context);
		}

        // GET: api/<SenderController>
		[HttpGet]
		public IEnumerable<Message> GetAll()
		{
			return _manager.GetAll();
		}
		
        // GET api/<SenderController>/5
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[HttpGet("{id}")]
		public ActionResult<Message> Get(int id)
		{
			Message message = _manager.GetById(id);
			if (message == null)
			{
				return NotFound("No such item, id: " + id);
			}
			else
			{
				return Ok(message);
			}
		}

	}
}
