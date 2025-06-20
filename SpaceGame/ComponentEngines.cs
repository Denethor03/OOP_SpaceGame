using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ComponentEngines : Component
    {
        public int JumpRange {get;}
        public ComponentEngines(int jumpRange)
        {
            this.JumpRange = jumpRange;
            this.Name = $"FTL Drive (Range: {jumpRange} units)";
            this.Description = $"A hyperdrive capable of jumps up to {jumpRange} light years.";
            this.Price = (int)Math.Pow(jumpRange, 2.5);
            this.Mass = 10 + jumpRange / 20;
        }
    }
}
