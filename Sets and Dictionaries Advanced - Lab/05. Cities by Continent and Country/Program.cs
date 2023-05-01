﻿Dictionary<string, Dictionary<string, List<string>>> continents = new();
int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string[] data = Console.ReadLine().Split();
    string continent = data[0];
    string country = data[1];
    string city = data[2];

    if (!continents.ContainsKey(continent))
    {
        continents.Add(continent, new Dictionary<string, List<string>>());
    }

    if (!continents[continent].ContainsKey(country))
    {
        continents[continent].Add(country, new List<string>());
    }

    continents[continent][country].Add(city);
}

foreach (var continent in continents)
{
    Console.WriteLine($"{continent.Key}:");
    foreach (var country in continent.Value)
    {
        Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
    }
}