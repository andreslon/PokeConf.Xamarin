using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using PokeConf.App.Models;
using Xamarin.Forms;

namespace PokeConf.App
{
    public class PokedexViewModel : BaseViewModel
    {
        public ObservableCollection<Pokemon> Items { get; set; }
        public Command LoadItemsCommand { get; set; }
        public ICommand OpenWebCommand { get; }
        public PokedexViewModel()
        { 
            Items = new ObservableCollection<Pokemon>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand()); 
            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://www.facebook.com/sharer/sharer.php?u=https%3A//github.com/andreslon/PokeConf.Xamarin")));
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return; 
            IsBusy = true; 
            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
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
    }
}
