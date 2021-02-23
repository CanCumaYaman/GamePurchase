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
            var result = _soldGameService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(SoldGame soldGame)
        {
           var result= _soldGameService.Add(soldGame);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(SoldGame soldGame)
        {
           var result= _soldGameService.Delete(soldGame);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(SoldGame soldGame)
        {
           var result= _soldGameService.Update(soldGame);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
