using System;

namespace allforoneapi.Services;

public class GuessItService
{
    private readonly Random random = new();

    public string Play(int guess, int max)
    {
        int number = random.Next(1, max + 1);

        if (guess == number)
        {
            return "Correct!";
        }

        return guess < number ? "Higher" : "Lower";
    }
}