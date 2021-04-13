using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.ViewModels;
using Application.Services;

namespace ConquestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionController : ControllerBase
    {
        private readonly RegionService _regionService;
        private readonly ILogger<RegionController> _logger;

        public RegionController(RegionService regionService, ILogger<RegionController> logger)
        {
            _regionService = regionService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<RegionVm[]>> Get()
        {
            var result = await _regionService.GetAll();
            return Ok(result);
        }
    }
}
