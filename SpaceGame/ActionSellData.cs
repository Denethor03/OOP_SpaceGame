using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionSellData : IAction
    {
        public string Name => "Sell stored data";

        public Result Execute(Ship ship)
        {
            if (ship.CurrentBody is BodyStation station)
            {
                ship.AddCredits(ship.ScanReward*station.ScanRewardModifier);
                double temp = ship.ScanReward*station.ScanRewardModifier;
                ship.ScanReward = 0;
                return new Result($"Data sold for {temp}");
            }
            else
            {
                return new Result("This should be never displayed");
            }
        }
    }
}
