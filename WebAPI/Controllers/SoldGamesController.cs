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
    public class SoldGamesController : ControllerBase
    {
        ISoldGameService _soldGameService;
        public SoldGamesController(ISoldGameService soldGameService)
        {
            _soldGameService = soldGameService;

        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            return Ok(_soldGameService.GetAll());
        }
        [HttpPost("add")]
        public IActionResult Add(SoldGame soldGame)
        {
            _soldGameService.Add(soldGame);
            return Ok();
        }
        [HttpPost("delete")]
        public IActionResult Delete(SoldGame soldGame)
        {
            _soldGameService.Delete(soldGame);
            return Ok();
        }
        [HttpPost("getall")]
        public IActionResult Update(SoldGame soldGame)
        {
            _soldGameService.Update(soldGame);
            return Ok();
        }

    }
}
