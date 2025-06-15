using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionExecuteSystemJump : IAction
    {
        public string Name { get; set; }
        private readonly StarSystem _destination;
        public ActionExecuteSystemJump(StarSystem system)
        {
            _destination = system;
            Name = $"{system.Name}";
        }

        public Result Execute(Ship ship)
        {
            ship.CurrentSystem = _destination;
            return new Result($"Jump to {_destination.Name} complete");
        }
    }
}
