using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_Using_Pokemon.Models;

namespace Tamagotchi_Using_Pokemon.Services
{
    public class PokemonService
    {
        public static PokemonModel FindBySpecies(string species)
        {
            var URI = $"https://pokeapi.co/api/v2/pokemon/{species.ToLower()}";
            var client = new RestClient(URI);
            var request = new RestRequest(URI, Method.Get);
            RestResponse response = client.Execute(request);

            return JsonConvert.DeserializeObject<PokemonModel>(response.Content);
        }
    }
}
