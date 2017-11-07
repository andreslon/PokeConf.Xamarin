using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PokeConf.App.Services
{ 
    public interface IPokemonStore<T> 
    {
        Task<T> GetPokemonAsync(string url);
        Task<IEnumerable<T>> GetPokemonsAsync();
    }
}
