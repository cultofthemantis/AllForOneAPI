using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using allforoneapi.Services;
using allforoneapi.Controllers;
namespace allforoneapi.Services;

public class MagicEightBallService
{
    public string Ask(string question)
    {
        string[] responses =
        {
            
        "Yes","No","Maybe","Ask again",
        "Definitely","Absolutely not","Unclear","It is certain"
    };

        Random random = new Random();

        string answer = responses[random.Next(0, 6)];
        return answer;
    }
}