using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop
{
    public class PokemonLetsGoEevee : GameItem, IPhysicalCopy
    {
        public PokemonLetsGoEevee()
        {
            this.GameName = "Pokémon: Let's Go Eevee";
            this.Price = 400;
            this.Id = "3";
        }
    }
}
