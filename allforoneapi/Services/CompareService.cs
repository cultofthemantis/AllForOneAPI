using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace allforoneapi.Services
{
    public class CompareService
    {
        public string Compare(int num1, int num2)
        {
          string comparison;

            if (num1 > num2)
            {
                
                comparison = $"{num1} is greater than {num2}.";
            }
            
            else if (num2 > num1)
            {
                comparison = $"{num2} is greater than {num1}.";
                
            }


            else
            {
                comparison = $"{num1} and {num2} are equal.";
                
            }

            return $"{comparison}";
        }
    }
}