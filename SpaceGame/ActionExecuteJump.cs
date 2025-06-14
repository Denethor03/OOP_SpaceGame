using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionExecuteJump : IAction
    {
        public string Name { get; set; }
        private readonly Body _destination;
        public ActionExecuteJump(Body body)
        {
            _destination = body;
            Name = $"{body.Name}";
        }

        public Result Execute(Ship ship)
        {
            ship.CurrentBody = _destination;
            return new Result($"Jump to {_destination.Name} complete");
        }
        
    }
}
