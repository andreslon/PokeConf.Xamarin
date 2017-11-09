using System;
using PokeConf.App.Models;

namespace PokeConf.App
{
    public class PokemonViewModel : BaseViewModel
    {
        public Pokemon Pokemon { get; set; }
        public PokemonViewModel(Pokemon pokemon = null)
        {
            Pokemon = pokemon;
        }
    }
}
