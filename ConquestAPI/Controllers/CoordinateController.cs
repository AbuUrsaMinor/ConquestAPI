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
    public class CoordinateController : ControllerBase
    {
        private readonly CoordinateService _coordinateService;
        private readonly ILogger<CoordinateController> _logger;

        public CoordinateController(CoordinateService coordinateService, ILogger<CoordinateController> logger)
        {
            _coordinateService = coordinateService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<CoordinateVm[]>> Get()
        {
            var result = await _coordinateService.GetAll();
            return Ok(result);
        }
    }
}
