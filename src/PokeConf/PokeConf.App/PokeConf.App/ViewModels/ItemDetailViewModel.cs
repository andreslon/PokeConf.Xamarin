using System;
using PokeConf.App.Models;

namespace PokeConf.App
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Pokemon Item { get; set; }
        public ItemDetailViewModel(Pokemon item = null)
        {
            
            Item = item;
        }
    }
}
