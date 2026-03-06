using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace allforoneapi.Services
{
    public class WakeUpService
    {
        public string GetInfo(string name, int wakeUpTime)
        {
            return $"Hey, {name}! You woke up at {wakeUpTime} today.";
        }
    }
}