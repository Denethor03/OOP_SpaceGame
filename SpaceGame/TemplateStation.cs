using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class TemplateStation
    {
        
        public  required string FactionTypeName { get; set; }

        public required string Description { get; set; }

        public bool HasShipyard { get; set; }
          
        public int TechLevel { get; set; }

        public float ScanRewardModifier { get; set; }
        
    }
}
