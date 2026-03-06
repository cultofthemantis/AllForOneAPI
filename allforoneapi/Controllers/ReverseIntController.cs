using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using allforoneapi.Services;
using allforoneapi.Service;

namespace allforoneapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseInController : ControllerBase
    {
        readonly ReverseIntService _service;
        public ReverseInController(ReverseIntService service)
        {
            _service = service;
        }

        [HttpGet]
        public string Reverse(int number)
        {
            return _service.Reverse(number);
        }
    }
    

}