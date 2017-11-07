using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PokeConf.App.Views
{
    public partial class PokemonPage : ContentPage
    { 
        ItemDetailViewModel viewModel; 
        public PokemonPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }
    }
}
