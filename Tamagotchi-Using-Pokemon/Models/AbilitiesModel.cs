using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi_Using_Pokemon.Models
{
    public class AbilitiesModel
    {
        public Ability ability { get; set; }
        public bool is_hidden { get; set; }
    }

    public class Ability
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
