using System;
using allforoneapi.Services;
namespace allforoneapi.Services;

public class Magic8BallService
{
    private readonly string[] responses =
    {
        "Yes","No","Maybe","Ask again",
        "Definitely","Absolutely not","Unclear","It is certain"
    };

    private readonly Random random = new();

    public string Ask()
    {
        return responses[random.Next(responses.Length)];
    }
}