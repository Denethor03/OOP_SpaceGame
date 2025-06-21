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
            if (ship.RemoveCredits(repairCost))
            {
                ship.Repair();
                
                return new Result($"Ship fully repaired for {repairCost:F1} credits");
            }
            else
            {
                return new Result(false,"Not enough credits to repair");
            }
        }
    }
}
