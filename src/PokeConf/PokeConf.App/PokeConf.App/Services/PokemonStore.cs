using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PokeConf.App;
using PokeConf.App.Models;

[assembly: Xamarin.Forms.Dependency(typeof(PokeConf.App.Services.PokemonStore))]
namespace PokeConf.App.Services
{
    public class PokemonStore : IPokemonStore<Pokemon>
    {
        string apiUri = "http://pokeapi.co/api/v2/pokemon-form/?limit=100&offset=0"; 
        HttpClient client; 
        List<Pokemon> items;
        public PokemonStore()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            items = new List<Pokemon>(); 
        }  
        public async Task<Pokemon> GetItemAsync(string url)
        {
            var RestUrl = $"{url}";
            var uri = new Uri(string.Format(RestUrl, string.Empty));
            var response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<Pokemon>(content);
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<Pokemon>> GetItemsAsync(bool forceRefresh = false)
        { 
            if (!string.IsNullOrWhiteSpace(apiUri))
            {
                var uri = new Uri(apiUri);
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<Pokedex>(content);
                    apiUri = result.next?.ToString();
                    for (int i = 0; i < result.results.Count(); i++)
                    {
                        result.results[i] = await GetItemAsync(result.results[i].url);
                    } 
                    items = result.results;
                }
            } 
            return items;
        }
    }
}
