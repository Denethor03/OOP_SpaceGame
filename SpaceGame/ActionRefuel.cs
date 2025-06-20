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
            double refuelCost = (ship.Hull.MaxFuel - ship.Fuel)*5;
            if (ship.Credits >= refuelCost)
            {
                ship.Fuel = ship.Hull.MaxFuel;
                ship.RemoveCredits(refuelCost);
                return new Result(true,$"Ship refueled for {refuelCost:F2} credits\nCurrent fuel: {ship.Fuel:F2}");
            }
            else
            {
                return new Result(false,$"Not enough cretids to refuel!");
            }
        }
    }
}
