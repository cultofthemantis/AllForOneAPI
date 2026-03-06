using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace allforoneapi.Service
{
    public class ReverseIntService
    {
        public string Reverse(int number)
        {
            string reversed = "";
            string input = number.ToString();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed = reversed + input[i];
            }

            return reversed;
        }
    }
}