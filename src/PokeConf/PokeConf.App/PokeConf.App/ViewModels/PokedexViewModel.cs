using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using PokeConf.App.Models;
using Xamarin.Forms;

namespace PokeConf.App
{
    public class PokedexViewModel : BaseViewModel
    {
        public ObservableCollection<Pokemon> Pokemons { get; set; }

        public ObservableCollection<Pokemon> PokemonsList
        {
            get
            {
                ObservableCollection<Pokemon> collection = new ObservableCollection<Pokemon>();
                List<Pokemon> FilteredPokemons = null;
                if (Pokemons != null)
                {
                    var filteredList = Pokemons.Select(x => x);
                    if (!String.IsNullOrWhiteSpace(SearchText))
                    {
                        filteredList = Pokemons.Where(x => x.name.ToUpper().Contains(SearchText.ToUpper()));
                    }
                    FilteredPokemons = filteredList.ToList<Pokemon>();
                    if (FilteredPokemons != null && FilteredPokemons.Any())
                    {
                        collection = new ObservableCollection<Pokemon>(FilteredPokemons);
                    }
                }
                return collection;
            }
        }

        private string searchText = string.Empty;
        public string SearchText
        {
            get { return searchText; }
            set
            {
                searchText = value;
                OnPropertyChanged("PokemonsList");
            }
        }

        public Command LoadItemsCommand { get; set; }
        public ICommand OpenWebCommand { get; }
        public ICommand SearchCommand { get; }
        public PokedexViewModel()
        {
            Pokemons = new ObservableCollection<Pokemon>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            SearchCommand = new Command(() => Search());
            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://www.facebook.com/sharer/sharer.php?u=https%3A//github.com/andreslon/PokeConf.Xamarin")));
        }

        public void Search()
        {
            OnPropertyChanged("PokemonsList");
        }
        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;
            IsBusy = true;
            try
            {
                Pokemons.Clear();
                var pokemons = await DataStore.GetPokemonsAsync();
                foreach (var pokemon in pokemons)
                {
                    Pokemons.Add(pokemon);
                }
                Search();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
        public async Task<Pokemon> LoadPokemon(string url)
        {
            IsBusy = true;
            try
            {
                var pokemon = await DataStore.GetPokemonAsync(url);
                return pokemon;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
            return null;
        }
    }
}
