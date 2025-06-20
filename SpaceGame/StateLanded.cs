using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class StateLanded : IShipState
    {
        public List<IAction> GetActions(Ship ship)
        {
            List<IAction> _actions = new List<IAction>();
            _actions.Add(new ActionLaunch());
            return _actions;
        } 
    }
}
