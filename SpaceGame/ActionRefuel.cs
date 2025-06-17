using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionRefuel : IAction
    {
        public string Name => "Refuel ship";
        public Result Execute(Ship ship)
        {
            ship.Fuel = ship.Hull.MaxFuel;
            return new Result($"Ship refueled\nCurrent fuel: {ship.Fuel}");
        }
    }
}
