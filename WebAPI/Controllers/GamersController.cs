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
            var result = _gamerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Gamer gamer)
        {
           var result= _gamerService.Add(gamer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Gamer gamer)
        {
           var result= _gamerService.Delete(gamer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Gamer gamer)
        {
          var result=  _gamerService.Update(gamer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
