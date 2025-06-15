using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class StateOrbitingBody : IShipState
    {
        
        public List<IAction> GetActions(Ship ship)
        {
            List<IAction> _actions = new List<IAction>();
            _actions.Add(new ActionJumpSelection());
            _actions.Add(new ActionGetInfo());
            _actions.Add(new ActionSystemJumpSelection());
            if (ship.CurrentBody is BodyStation) { _actions.Add(new ActionDock()); }
            
            return _actions;
            
        }
    }
}
