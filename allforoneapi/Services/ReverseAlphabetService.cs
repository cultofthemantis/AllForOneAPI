using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace allforoneapi.Controllers
{
    public class ReverseAlphabetService
    {
        public string Reverse(string input)
        {
            string reversed = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed = reversed + input[i];
            }

            return reversed;
        }
    }
}