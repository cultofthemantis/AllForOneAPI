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
    public class ReverseAlphabetController : ControllerBase
    {
        readonly ReverseAlphabetService _service;

        public ReverseAlphabetController(ReverseAlphabetService service)
        {
            _service = service;
        }

        [HttpGet]
        public string Reverse(string input)
        {
            return _service.Reverse(input);
        }
    }
}