using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionGetInfo : IAction
    {   
        public string Name => "Get Information";
        public Result Execute(Ship ship)
        {
            return new Result($"Current location:{ship.CurrentBody.Name} at system {ship.CurrentSystem.Name}\n" +
                $"Current fuel: {ship.Fuel}\n" +
                $"Current credits: {ship.Credits}\n" +
                $"Scanned data value: {ship.ScanReward}");
        }
        
    }
}
