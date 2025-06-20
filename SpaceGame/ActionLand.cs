using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionLand : IAction
    {
        public string Name => "Land";
        
        public Result Execute(Ship ship)
        {
            ship.ChangeState(new StateLanded());
            return new Result("Landing succesfull");
        }
    }
}
