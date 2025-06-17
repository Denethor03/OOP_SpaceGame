using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class TemplateStar
    {
      
        
        public required string TypeName { get; set; }

        public required string Description { get; set; }

        public bool CanRefuel { get; set; }

        public double DamageModifier {  get; set; }
        public int MinScanReward { get; set; }
        public int MaxScanReward { get; set; }

    }
}
