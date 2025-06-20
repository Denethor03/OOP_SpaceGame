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
            _actions.Add(new ActionGetInfo());
            _actions.Add(new ActionJumpSelection());
            _actions.Add(new ActionSystemJumpSelection());
            _actions.Add(new ActionScan());
            if (ship.CurrentBody is BodyStation) { _actions.Add(new ActionDock()); }
            if (ship.CurrentBody is BodyPlanet planet && planet.CanLand) { _actions.Add(new ActionLand()); }
            if (ship.CurrentBody is BodyStar && ship.Fuel != ship.Hull.MaxFuel) {_actions.Add(new ActionDeployFuelScoop()); }
            
            return _actions;
            
        }
    }
}
