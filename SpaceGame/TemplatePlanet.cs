using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class TemplatePlanet
    {
        public required string TypeName { get; set; }
        public required string Description { get; set; }
        public int MinScanReward { get; set; }
        public int MaxScanReward { get; set; }
        public bool Landable { get; set; }
    }
}
