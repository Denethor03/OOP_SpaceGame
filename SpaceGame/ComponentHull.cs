using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ComponentHull : Component
    {
        public int HullDurability { get; }
        public int MaxFuel {  get; }
        public ComponentHull(int durability,int fuel)
        {
            HullDurability = durability;
            MaxFuel = fuel;
            this.Name = $"Reinforced Bulkhead Mk-{Math.Round((double)durability / 100)}"; 
            this.Description = $"A solid hull plating structure providing {durability} hit points.";
            this.Price = durability * 15;
            this.Mass = durability * 15 + 10;
        }
    }
}
