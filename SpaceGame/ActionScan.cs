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
            ship.ScanReward += ship.GetCurrentBody().scanValue;
            return new Result("Scan completed");
        }
    }
}
