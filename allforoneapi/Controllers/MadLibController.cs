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
    public class MadLibController : ControllerBase
    {
        readonly MadLibService _service;

        public MadLibController(MadLibService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{name}/{place}/{adjective}/{noun}/{adjective2}/{verb}")]
        public string Story(string name, string place, string adjective, string noun, string adjective2, string verb)
        {
            return _service.Story(name, place, adjective, noun, adjective2, verb);
        }
    }
}