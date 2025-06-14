using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionUndock : IAction
    {
        public string Name => "Undock";

        public Result Execute(Ship ship)
        {
            ship.ChangeState(new StateOrbitingBody());
            return new Result($"Undocked. Now orbiting {ship.CurrentBody.Name}");
        }
    }
}
