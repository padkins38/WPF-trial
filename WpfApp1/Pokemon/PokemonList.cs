using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{
    public class PokemonList
    {
        /*"count":1118,
        "next":"https://pokeapi.co/api/v2/pokemon?offset=20&limit=20",
        "previous":null,
        "results": [+] */

        // Don't need the next and previous

        /*public string next { get; set; }
        public string previous { get; set; }*/


        public string count { get; set; }
        public List<Results> results { get; set; }
    }
}
