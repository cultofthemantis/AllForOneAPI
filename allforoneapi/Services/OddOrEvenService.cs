using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace allforoneapi.Controllers
{
    public class OddOrEvenService
    {
        public string Check(int number)
        {
            if (number % 2 == 0)
            {
                return $"{number} is even.";
                
            }
            else
            {
                return $"{number} is odd.";
                
            }
        }
    }
}