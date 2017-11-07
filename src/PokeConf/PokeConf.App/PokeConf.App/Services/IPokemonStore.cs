using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PokeConf.App.Services
{ 
    public interface IPokemonStore<T> 
    {
        Task<T> GetItemAsync(string id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
