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
            if (ship.CurrentBody is BodyStation && ship.Fuel != ship.Hull.MaxFuel) _actions.Add(new ActionRefuel());
            if (ship.CurrentBody is BodyStation && ship.ScanReward != 0) _actions.Add(new ActionSellData());
            if (ship.CurrentBody is BodyStation) _actions.Add(new ActionViewShop());
            if (ship.CurrentBody is BodyStation && ship.Hull.HullDurability != ship.Durability) _actions.Add(new ActionRepair());
            return _actions;
        }
    }
}
