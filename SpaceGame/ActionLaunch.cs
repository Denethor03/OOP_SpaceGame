using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionLaunch : IAction
    {
        public string Name => "Launch";

        public Result Execute(Ship ship)
        {
            ship.ChangeState(new StateOrbitingBody());
            return new Result($"Launch succesfull. Now orbiting {ship.CurrentBody.Name}");
        }
    }
}
