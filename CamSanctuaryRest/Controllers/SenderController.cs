﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CamSanctuaryRest.Managers;
using CamSanctuaryRest.Models;

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
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<SenderController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<SenderController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<SenderController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
