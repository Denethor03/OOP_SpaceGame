using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionExecuteSystemJump : IAction
    {
        public string Name { get; set; }
        private readonly StarSystem _destination;
        public ActionExecuteSystemJump(StarSystem system,Ship ship)
        {
            _destination = system;
            Name = $"{system.Name} ({Vector3.Distance(ship.CurrentSystem.SystemCoords,system.SystemCoords):F1} ly)";
        }

        public Result Execute(Ship ship)
        {
            double jumpDistance = Vector3.Distance(ship.CurrentSystem.SystemCoords, _destination.SystemCoords);
            if (ship.Engines.JumpRange < jumpDistance)
            {
                return new Result(false,$"Jump distance ({jumpDistance:F2} ly)" +
                    $" excedes current engines jump range ({ship.Engines.JumpRange:F2} ly)");
            }
            //assume that each jump consumes 1 unit of fuel per 1 unit of distance
            if (ship.Fuel < jumpDistance * 1)
            {
                return new Result(false,$"Not enough fuel to perform jump to {_destination.Name}");
            }
            else
            {
                ship.Fuel-=jumpDistance*1; // "1" could be replaced with some modifier based on ship mass or something else
                ship.CurrentSystem = _destination;
                ship.CurrentBody = _destination.Bodies[0];
                ship.Durability -= ship.Hull.HullDurability / 50; //jumping slightly damages ship
                return new Result($"Jump to {_destination.Name} complete");
            }
            
        }
    }
}
