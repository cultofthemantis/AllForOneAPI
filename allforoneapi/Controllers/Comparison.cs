using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using allforoneapi.Services;
using Microsoft.AspNetCore.Mvc;
using allforoneapi.Controllers;

namespace allforoneapi.Controllers
{
 
    [ApiController]
    [Route("[controller]")]
    public class ComparisonController : ControllerBase
    {
        public readonly CompareService _service;

        public ComparisonController(CompareService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{num1}/{num2}")]
        public string Compare(int num1, int num2)
        {
            return _service.Compare(num1, num2);
        }
    }
    
}