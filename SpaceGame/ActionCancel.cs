using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionCancel : IAction
    {
        public string Name => "Cancel";

        public Result Execute(Ship ship)
        {
            return new Result("Cancelled", new List<IAction>());
        }
    }
}
