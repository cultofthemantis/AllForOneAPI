using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using allforoneapi.Services;
using allforoneapi.Controllers;

namespace allforoneapi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MagicEightBallController : ControllerBase
    {
        public readonly MagicEightBallService _service;

        public MagicEightBallController(MagicEightBallService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{question}")]
        public string Ask(string question)
        {
            return _service.Ask(question);
        }
    }
}