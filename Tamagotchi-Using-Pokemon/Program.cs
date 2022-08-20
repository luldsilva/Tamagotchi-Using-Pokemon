using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text.Json;
using Tamagotchi_Using_Pokemon.Models;
using Tamagotchi_Using_Pokemon.Services;

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

        static void Main(string[] args)
        {
            string pokemonName = "squirtle";
            var pokemonAttributes = PokemonService.FindBySpecies(pokemonName);

            Console.WriteLine("Nome pokemon: " + pokemonName);
            Console.WriteLine("Altura: " + pokemonAttributes.height);
            Console.WriteLine("Peso: " + pokemonAttributes.weight + "\n");

            foreach(AbilitiesModel abilities in pokemonAttributes.abilities)
            {
                Console.WriteLine("Habilidades: " + abilities.ability.name);
            }

            Console.WriteLine("----------------------------------------------");
        }

        //foreach (PokemonModel pokemon in listPokemons.results)
        //{
        //    Console.WriteLine("Nome: " + pokemon.name + "\n");
        //    Console.WriteLine("URI: " + pokemon.url);
        //    Console.WriteLine("------------------------------");
        //}

    }
}
