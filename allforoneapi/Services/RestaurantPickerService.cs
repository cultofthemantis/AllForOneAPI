using System;
using System.Collections.Generic;
using allforoneapi.Services;
namespace allforoneapi.Services;

public class RestaurantPickerService
{
    private readonly Random random = new();

    public Dictionary<string, string[]> restaurants = new()
    {
        { "italian", new[] { "Olive Garden","Pasta Palace","Roma Dine","Venice Cafe" } },
        { "chinese", new[] { "Golden Wok","Dragon Express","Panda Garden","Great Wall" } },
        { "mexican", new[] { "El Sombrero Bonito","Taco Loco","Casa Bonita","Fiesta Mexicana" } }
    };

    public string Pick(string category)
    {
        if (string.IsNullOrWhiteSpace(category) ||
            !restaurants.ContainsKey(category.ToLower()))
        {
            return null;
        }

        var list = restaurants[category.ToLower()];
        return list[random.Next(list.Length)];
    }
}