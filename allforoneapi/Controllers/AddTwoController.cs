using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using allforoneapi.Controllers;
using allforoneapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace allforoneapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumbers
    {
        
        public readonly AddTwoService _service;

        public  AddTwoNumbers(AddTwoService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("Sum/{num1}/{num2}")]
        public string Add(int num1, int num2)
        {
            return _service.Add(num1, num2);
        }
    }
}