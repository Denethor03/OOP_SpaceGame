using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionDeployFuelScoop : IAction
    {
        public string Name => "Refuel from star (damages components!)";

        public Result Execute(Ship ship)
        {
            double fuelReplenished = ship.Hull.MaxFuel-ship.Fuel;
            
            double damageTaken= 0;
            if (ship.CurrentBody is BodyStar star && star.CanRefuel) 
            {
                damageTaken = ship.Hull.HullDurability * 0.05 * star.DamageModifier*+fuelReplenished*0.1;
                ship.Fuel = ship.Hull.MaxFuel;
                ship.Durability -= damageTaken;
                return new Result($"Refuel successful. Damage taken:{damageTaken:F1}");
            }
            else
            {
                return new Result(false,"This star is too dangerous to refuell from");
            }
                
        }
    }
}
