using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamersController : ControllerBase
    {
        IGamerService _gamerService;
        public GamersController(IGamerService gamerService)
        {
            _gamerService = gamerService;

        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            return Ok(_gamerService.GetAll());
        }
        [HttpPost("add")]
        public IActionResult Add(Gamer gamer)
        {
            _gamerService.Add(gamer);
            return Ok();
        }
        [HttpPost("delete")]
        public IActionResult Delete(Gamer gamer)
        {
            _gamerService.Delete(gamer);
            return Ok();
        }
        [HttpPost("getall")]
        public IActionResult Update(Gamer gamer)
        {
            _gamerService.Update(gamer);
            return Ok();
        }

    }
}
