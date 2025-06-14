using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionDock : IAction
    {
        public string Name => "Dock at current station";

        public Result Execute(Ship ship)
        {
            ship.ChangeState(new StateDocked());
            return new Result("Docking complete");
        }
    }
}
