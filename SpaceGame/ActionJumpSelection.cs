using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionJumpSelection : IAction
    {
        public string Name => "Perform jump in system";
        public Result Execute(Ship ship)
        {
            List<IAction> followUpAction = new List<IAction>();
            foreach(Body body in ship.CurrentSystem.Bodies)
            {
                if (ship.CurrentBody != body)
                {
                    followUpAction.Add(new ActionExecuteJump(body, ship));
                }
            }
            followUpAction.Add(new ActionCancel());
            return new Result("Please select jump destination:",followUpAction);
        }
    }
}
