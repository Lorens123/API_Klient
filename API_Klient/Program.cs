using System.Security.AccessControl;
using RestSharp;
using System.Text.Json;





RestClient pokeClient = new RestClient("https://pokeapi.co/api/v2/");
RestRequest pokeRequest = new RestRequest("pokemon/pikachu");

IRestResponse pokeResponse = pokeClient.Get(pokeRequest);

// Console.WriteLine(pokeResponse.Content);



// RestClient swClient = new RestClient("https://swapi.dev/api/");
// RestRequest swRequest = new RestRequest("people/3");
// IRestResponse swResponse = swClient.Get(swRequest);

// // Console.WriteLine(swResponse.Content);


Pokemon p = JsonSerializer.Deserialize<Pokemon>(pokeResponse.Content);

Console.WriteLine(p.name);
Console.WriteLine(p.weight);
Console.WriteLine(p.is_default);

Console.ReadLine();












