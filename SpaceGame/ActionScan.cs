using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionScan : IAction
    {
        public string Name => "Scan object";
        public Result Execute(Ship ship)
        {

            if (!ship.CurrentBody.Scanned)
            { 
                ship.ScanReward += ship.CurrentBody.scanValue;
                ship.CurrentBody.Scanned = true;
                return new Result($"Scan completed.\n" +
                    $"Object: {ship.CurrentBody.Name}\n" +
                    $"{ship.CurrentBody.Description}\n" +
                    $"Scan value: {ship.CurrentBody.scanValue}");
            }
            else
            {
                return new Result($"Scan completed.\n" +
                    $"Planet: {ship.CurrentBody.Name}\n" +
                    $"{ship.CurrentBody.Description}\n" +
                    $"Scan value: already scanned");
            }
        }
    }
}
