using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal abstract class Component
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public double Mass { get; protected set; }

        public Component()
        {
            Name = string.Empty;
            Description = string.Empty;
        }
    }
}
