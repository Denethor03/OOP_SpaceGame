using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionViewShop : IAction
    {
        public string Name => "View station stock";
        public Result Execute(Ship ship)
        {
            List<IAction> followUpAction = new List<IAction>();
            if (ship.CurrentBody is BodyStation station) {
                foreach (Component component in station.Stock)
                {
                    followUpAction.Add(new ActionBuyComponent(component));
                }
                followUpAction.Add(new ActionCancel());
            }
            return new Result("Component list:", followUpAction);
        }
    }
}
