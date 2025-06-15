using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class Ship
    {
        public readonly Universe currentUniverse;
        private Body currentBody;
        private StarSystem currentSystem;
        private IShipState currentState;
        private int credits;
        private int fuel;
        private int maxFuel;
    
        public int ScanReward { get; set; }
        public int Fuel { get=> fuel; set => fuel = value; }
        public int MaxFuel { get => maxFuel; set => maxFuel = value ; }
        public int Credits { get => credits; set => credits = value; }
        public StarSystem CurrentSystem { get=> currentSystem; set => currentSystem = value; }

        public Body CurrentBody { get => currentBody; set => currentBody = value; }

        public Ship(Universe universe)
        {
            this.currentUniverse = universe;
            currentSystem = universe.starSystems[0]; //assume first system is starter system
            currentBody = currentSystem.Bodies[0]; //assume sun is 1st body in list
            this.currentState = new StateDocked();
            Credits = 0;
            MaxFuel = 100;
            Fuel = MaxFuel;
        }

        public void ChangeState(IShipState state)
        {
            currentState = state;
        }

        public List<IAction> GetActionList()
        {
            return currentState.GetActions(this);
        }

        public Result PerformAction(IAction action)
        {
            return action.Execute(this);
        }

        public Body GetCurrentBody()
        {
            return currentBody;
        }
       
    }
}
