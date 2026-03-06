using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using allforoneapi.Services;

using Microsoft.AspNetCore.Mvc;

namespace allforoneapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WakeUpController : ControllerBase
    {
       public readonly WakeUpService _service;

        public WakeUpController(WakeUpService service)
        {
            _service = service;
        }

        [HttpGet]
        public string GetInfo(string name, int wakeUpTime)
        {
            return _service.GetInfo(name, wakeUpTime);
        }
    }
}