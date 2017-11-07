using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PokeConf.App.Views
{
    public partial class PokemonPage : ContentPage
    { 
        PokemonViewModel viewModel; 
        public PokemonPage(PokemonViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }
    }
}
