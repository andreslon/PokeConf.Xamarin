using System;
using PokeConf.App.Models;

namespace PokeConf.App
{
    public class PokemonViewModel : BaseViewModel
    {
        public Pokemon Item { get; set; }
        public PokemonViewModel(Pokemon item = null)
        {
            Item = item;
        }
    }
}
