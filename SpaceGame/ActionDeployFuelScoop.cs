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
                damageTaken = ship.Hull.HullDurability * 0.05 + 5 * star.DamageModifier+fuelReplenished*0.1;
                ship.Fuel = ship.Hull.MaxFuel;
                if (ship.TakeDamage(damageTaken))
                {
                    return new Result($"Refuel successful. Damage taken: {damageTaken:F1}");
                }
                else
                {
                    return new Result(false,"Critical systems failure! Your ship was destroyed by the intense solar radiation! " +
                "Your emergency beacon was activated, and you have been towed to your last registered station. " +
                "An insurance premium has been deducted from your account.");
                }
                
                
            }
            else
            {
                return new Result(false,"This star is too dangerous to refuell from");
            }
                
        }
    }
}
