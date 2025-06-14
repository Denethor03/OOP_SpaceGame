using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionJumpSelection : IAction
    {
        public string Name => "Perform jump";
        public Result Execute(Ship ship)
        {
            List<IAction> followUpAction = new List<IAction>();
            foreach(Body body in ship.CurrentSystem.Bodies)
            {
                followUpAction.Add(new ActionExecuteJump(body));
            }

            return new Result("Please select jump destination:",followUpAction);
        }
    }
}
