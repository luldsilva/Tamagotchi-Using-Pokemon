using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text.Json;
using Tamagotchi_Using_Pokemon.Models;

namespace Tamagotchi_Using_Pokemon
{
    //Implementar as praticas de SOLID nesse codigo
    class Program
    {
        PokemonModel _pokeModel;
        public Program()
        {
            _pokeModel = new PokemonModel();
        }

        public class Response
        {
            public int count { get; set; }
            public string next { get; set; }
            public string previous { get; set; }
            public List<PokemonModel> results { get; set; }
        }

        static void Main(string[] args)
        {
            var URI = $@"https://pokeapi.co/api/v2/pokemon/";
            var client = new RestClient(URI);
            var request = new RestRequest(URI, Method.Get);
            RestResponse response = client.Execute(request);
            Deserializar(response.Content);
        }

        public static void Deserializar(string response)
        {

            var listPokemons = JsonConvert.DeserializeObject<Response>(response);

            foreach(PokemonModel pokemon in listPokemons.results)
            {
                Console.WriteLine("Nome: " + pokemon.name + "\n");
                Console.WriteLine("URI: " + pokemon.url);
                Console.WriteLine("------------------------------");
            }
        }
    }
}
