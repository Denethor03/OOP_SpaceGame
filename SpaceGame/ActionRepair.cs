using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionRepair : IAction
    {
        public string Name => "Repair";
        public Result Execute(Ship ship)
        {
            double repairCost = (ship.Hull.HullDurability - ship.Durability) * 10;
            if (ship.Credits >= repairCost)
            {
                ship.Durability = ship.Hull.HullDurability;
                ship.RemoveCredits(repairCost);
                return new Result("Ship fully repaired");
            }
            else
            {
                return new Result("Not enough credits to repair");
            }
        }
    }
}
