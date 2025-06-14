using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class StateDocked : IShipState
    {
        
        public List<IAction> GetActions(Ship ship)
        {
            List<IAction> _actions = new List<IAction>();
            _actions.Add(new ActionUndock());
            _actions.Add(new ActionGetInfo());
            if (ship.GetCurrentBody() is BodyStation) _actions.Add(new ActionRefuel());
            return _actions;
        }
    }
}
