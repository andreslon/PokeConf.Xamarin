using System;
using System.Collections.Generic;
using System.Linq;
using PokeConf.App.Models;
using Xamarin.Forms;

namespace PokeConf.App.Views
{
    public partial class PokedexPage : ContentPage
    {
        PokedexViewModel viewModel;

        public PokedexPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = viewModel = new PokedexViewModel();
            this.PokemonsListView.ItemAppearing += (s, e) =>
            {
                //var item = (Pokemon)e.Item;
                //if (item.name == viewModel?.Items?.Last().name)
                    //if (viewModel.Items.Count > 0)
                        //viewModel.LoadItemsCommand.Execute(null);
            };
        }

        async void OnPokemonsSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Pokemon;
            if (item == null)
                return;

            var pokemon =await viewModel.LoadPokemon(item.url);

            await Navigation.PushAsync(new PokemonPage(new PokemonViewModel(pokemon)));

            // Manually deselect item
            PokemonsListView.SelectedItem = null;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Pokemons.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}
