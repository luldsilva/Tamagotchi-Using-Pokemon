using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi_Using_Pokemon.Models
{
    public class PokemonModel
    {
        public List<AbilitiesModel> abilities { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
    }
}
