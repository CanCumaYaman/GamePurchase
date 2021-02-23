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
            var result = _campaignService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
            
        }
        [HttpPost("add")]
        public IActionResult Add(Campaign campaign)
        {
           var result=_campaignService.Add(campaign);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Campaign campaign)
        {
            var result=_campaignService.Delete(campaign);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Campaign campaign)
        {
            var result=_campaignService.Update(campaign);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
