using RestSharp;
using System.Text.Json;

RestClient client = new("https://swapi.py4e.com/api/");

int characterNumber = 3;
RestRequest request = new($"people/{characterNumber}/");

RestResponse response = client.GetAsync(request).Result;


Character p = JsonSerializer.Deserialize<Character>(response.Content);


Console.WriteLine(p.mass);
// Console.WriteLine(response.Content);
// File.WriteAllText("pokemon.json", response.Content);

Console.ReadLine();