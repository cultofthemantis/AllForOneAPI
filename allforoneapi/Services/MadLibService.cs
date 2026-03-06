using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using allforoneapi.Services;
namespace allforoneapi.Controllers
{
    public class MadLibService
    {
        public string Story(string name, string place, string adjective, string noun, string adjective2, string verb)
        {
            return $"{name} went to {place} and saw a {adjective} {noun}. It was so {adjective2}, {name} {verb}ed away!";
        }
    }
}