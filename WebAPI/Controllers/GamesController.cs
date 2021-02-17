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
    public class GamesController : ControllerBase
    {
        IGameService _gameService;
        public GamesController(IGameService gameService)
        {
            _gameService = gameService;

        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            return Ok(_gameService.GetAll());
        }
        [HttpPost("add")]
        public IActionResult Add(Game game)
        {
            _gameService.Add(game);
                return Ok();
        }
        [HttpPost("delete")]
        public IActionResult Delete(Game game)
        {
            _gameService.Delete(game);
            return Ok();
        }
        [HttpPost("getall")]
        public IActionResult Update(Game game)
        {
            _gameService.Update(game);
            return Ok();
        }

    }
}
