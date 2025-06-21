using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionSelfDestruct : IAction
    {
        public string Name => "Self destruct";
        public Result Execute(Ship ship)
        {
            ship.CurrentBody = ship.LastStation;
            ship.CurrentSystem = ship.LastStarSystem;
            ship.ChangeState(new StateDocked());
            double insurance = (ship.Hull.Price + ship.Engines.Price + ship.Scanner.Price) * 0.05;
            if (!ship.RemoveCredits(insurance))
            {
                ship.Hull = new ComponentHull(100, 10);
                ship.Scanner = new ComponentScanner(1);
                ship.Engines = new ComponentEngines(10);
                return new Result(false, "Ship destroyed. Spawning at last station. Components replaced with basic ones");
            }
            else
            {
                return new Result(false,$"Ship destroyed. Spawning at last station. {insurance} credits deduced for insurance");
            }
        }
    }
}
