using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using allforoneapi.Services;
using allforoneapi.Controllers;


namespace allforoneapi.Controllers
{
 [ApiController]
    [Route("[controller]")]
    public class OddOrEvenController : ControllerBase
    {
       readonly OddOrEvenService _service;

        public OddOrEvenController(OddOrEvenService service)
        {
            _service = service;
        }

        [HttpGet]
        public string Check(int number)
        {
            return _service.Check(number);
        }
    }
}