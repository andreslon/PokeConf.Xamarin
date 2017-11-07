using System;
using System.Collections.Generic;

namespace PokeConf.App.Models
{ 
    public class Pokedex
    {
        public int count { get; set; }
        public object previous { get; set; }
        public List<Pokemon> results { get; set; }
        public object next { get; set; }
    }
}
