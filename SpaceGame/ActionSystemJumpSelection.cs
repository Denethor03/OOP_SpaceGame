using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionSystemJumpSelection : IAction
    {
        public string Name => "Perform jump to another system";
        public Result Execute(Ship ship)
        {
            List<IAction> followUpAction = new List<IAction>();
            foreach (StarSystem system in ship._currentUniverse.starSystems)
            {
                followUpAction.Add(new ActionExecuteSystemJump(system,ship));
            }
            followUpAction.Add(new ActionCancel());
            return new Result("Please select jump destination:", followUpAction);
        }
    }
}
