using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CamSanctuaryRest.Managers;
using CamSanctuaryRest.Models;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CamSanctuaryRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiverController : ControllerBase
    {
        private readonly ReceiverManager _manager;

        public ReceiverController(CamsanctuarydbContext context)
        {
            _manager = new ReceiverManager(context);
        }
        
        // POST api/<ReceiverController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult <Message> Post([FromBody] Message value)
        {
            try
            {
                Message newMessage = _manager.AddMessage(value);
                string uri = Url.RouteUrl(RouteData.Values) + "/" + newMessage.Id;
                return Created(uri, newMessage);

            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("video")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult PostVideo([FromBody] IEnumerable<VideoData> value)
        {
            try
            {
                _manager.AddVideo(value);
                return Created("", null);

            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
