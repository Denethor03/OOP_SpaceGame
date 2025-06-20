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
                double scanValue = ship.CurrentBody.ScanValue * ship.Scanner.ScannerQuality;
                ship.ScanReward += scanValue;
                ship.CurrentBody.Scanned = true;
                return new Result($"Scan completed.\n" +
                    $"Object: {ship.CurrentBody.Name}\n" +
                    $"Position: {ship.CurrentBody.Coordinates}\n" +
                    $"{ship.CurrentBody.Description}\n" +
                    $"Scan value: {scanValue}");
            }
            else
            {
                return new Result($"Scan completed.\n" +
                    $"Object: {ship.CurrentBody.Name}\n" +
                    $"Position: {ship.CurrentBody.Coordinates}\n" +
                    $"{ship.CurrentBody.Description}\n" +
                    $"Scan value: already scanned");
            }
        }
    }
}
