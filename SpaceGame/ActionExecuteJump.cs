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
            double jumpDistance = Vector3.Distance(ship.CurrentBody.Coordinates,_destination.Coordinates);
            if (ship.Engines.JumpRange < jumpDistance/10000)
            {
                return new Result(false,"Jump excedes current engines jump range"); 
            }
            
            if (ship.Fuel < jumpDistance*1/10000) //distances in systems way samller compared to distances between systems
            {
                return new Result(false,"Not enough fuel to perform jump");
            }
            else
            {
                ship.Fuel -= jumpDistance * 1/10000;
                ship.CurrentBody = _destination;
                return new Result($"Jump to {_destination.Name} complete");
            }
        }
        
    }
}
