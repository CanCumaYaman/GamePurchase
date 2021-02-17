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
    public class CampaignsController : ControllerBase
    {
        ICampaignService _campaignService;
        public CampaignsController(ICampaignService campaignService)
        {
            _campaignService = campaignService;

        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            return Ok(_campaignService.GetAll());
        }
        [HttpPost("add")]
        public IActionResult Add(Campaign campaign)
        {
            _campaignService.Add(campaign);
            return Ok();
        }
        [HttpPost("delete")]
        public IActionResult Delete(Campaign campaign)
        {
            _campaignService.Delete(campaign);
            return Ok();
        }
        [HttpPost("getall")]
        public IActionResult Update(Campaign campaign)
        {
            _campaignService.Update(campaign);
            return Ok();
        }

    }
}
