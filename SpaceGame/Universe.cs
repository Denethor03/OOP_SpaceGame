using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class Universe
    {
        public readonly List<StarSystem> starSystems;

        public Universe(List<StarSystem> starSystems)
        {
            this.starSystems = starSystems;
        }
    }
}
