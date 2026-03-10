using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using allforoneapi.Services;
namespace allforoneapi.Services;

public class GuessItService
{
        public readonly Random random = new();
        public int number;
        public string Play(int guess)
        {
                number = random.Next(1, 101);

            if (guess == number)
            {
                return "Correct!";
            }

            string result = guess < number ? "Higher" : "Lower";
            return result;
        }

     }
