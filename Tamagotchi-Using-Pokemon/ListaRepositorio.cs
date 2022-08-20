using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_Using_Pokemon.Models;

namespace Tamagotchi_Using_Pokemon
{
    public class ListaRepositorio
    {
        public List<PokemonModel> pokemons = new List<PokemonModel>();

        public ListaRepositorio()
        {
            pokemons.Add(new PokemonModel());
        }
    }
}
