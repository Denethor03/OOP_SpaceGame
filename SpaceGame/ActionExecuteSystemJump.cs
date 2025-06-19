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
            Name = $"{system.Name} ({Vector3.Distance(ship.CurrentSystem.SystemCoords,system.SystemCoords)} ly)";
        }

        public Result Execute(Ship ship)
        {
            ship.CurrentSystem = _destination;
            ship.CurrentBody = _destination.Bodies[0];
            return new Result($"Jump to {_destination.Name} complete");
        }
    }
}
