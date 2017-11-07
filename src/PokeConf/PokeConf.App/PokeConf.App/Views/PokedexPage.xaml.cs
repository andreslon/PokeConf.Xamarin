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
            this.ItemsListView.ItemAppearing += (s, e) =>
            {
                var item = (Pokemon)e.Item;
                if (item.name == viewModel?.Items?.Last().name)
                    if (viewModel.Items.Count > 0)
                        viewModel.LoadItemsCommand.Execute(null);
            };
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            await Navigation.PushAsync(new PokemonPage(new ItemDetailViewModel(item)));

            // Manually deselect item
            ItemsListView.SelectedItem = null;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}
