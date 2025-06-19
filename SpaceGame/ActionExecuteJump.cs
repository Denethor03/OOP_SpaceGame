using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionExecuteJump : IAction
    {
        public string Name { get; set; }
        private readonly Body _destination;
        private string typeSymbol = string.Empty;
        public ActionExecuteJump(Body body, Ship ship)
        {
            _destination = body;
            if (body is BodyStar) typeSymbol = "*";
            if (body is BodyPlanet) typeSymbol = "o";
            if (body is BodyStation) typeSymbol = "[]";

            Name = $"{typeSymbol} {body.Name} ({Vector3.Distance(ship.CurrentBody.Coordinates,body.Coordinates)} ls)";
        }

        public Result Execute(Ship ship)
        {
            ship.CurrentBody = _destination;
            return new Result($"Jump to {_destination.Name} complete");
        }
        
    }
}
