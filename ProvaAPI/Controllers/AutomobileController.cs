using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProvaAPI.Interfaces.Services;
using ProvaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaAPI.Controllers
{
    [ApiController]
    [Route("api/automobile")]
    public class AutomobileController : ControllerBase
    {
        private readonly IAutomobileServices automobileService;

        public AutomobileController(IAutomobileServices automobileService)
        {
            this.automobileService = automobileService;
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(Automobile automobile)
        {
            return Ok(automobileService.CreateAutomobile(automobile));            
        }

        [HttpGet]
        [Route("list")]
        public IActionResult GetAllAutomobiles()
        {
            return Ok(automobileService.GetAutomobiles());
        }
        
    }
}
