using System;
using System.Collections.Generic;

namespace PokeConf.App.Models
{
    public class Pokemon
    {
        public string url { get; set; }
        public string name { get; set; }
        public string image { get; set; }

        public bool is_battle_only { get; set; }
        public Sprites sprites { get; set; }
        public VersionGroup version_group { get; set; }
        public int form_order { get; set; }
        public bool is_mega { get; set; }
        public List<object> form_names { get; set; }
        public int id { get; set; }
        public bool is_default { get; set; }
        public List<object> names { get; set; }
        public string form_name { get; set; }
        public int order { get; set; } 
    }
}
