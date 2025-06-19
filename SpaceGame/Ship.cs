using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class Ship
    {
        public readonly Universe _currentUniverse;
        private Body _currentBody;
        private StarSystem _currentSystem;
        private IShipState _currentState;
        private double _credits;
        private double _scanReward;

        private int _fuel;
        private double _durability;
        public double Durability { get => _durability; set => _durability = value; }
        public ComponentHull Hull { get; set; }
        public ComponentEngines Engines { get; set; }
        public ComponentScanner Scanner { get; set; }
    
        public double ScanReward { get => _scanReward; set => _scanReward = value; }
        public int Fuel 
        { get => _fuel; set 
            {
                if (value > Hull.MaxFuel)
                {
                    _fuel = Hull.MaxFuel;
                }
                else
                {
                    _fuel = value;
                }
            }
        }
        public double Credits => _credits;
        public StarSystem CurrentSystem { get=> _currentSystem; set => _currentSystem = value; }

        public Body CurrentBody { get => _currentBody; set => _currentBody = value; }

        public Ship(Universe universe)
        {
            this._currentUniverse = universe;
            _currentSystem = universe.starSystems[0]; //assume first system is starter system
            _currentBody = _currentSystem.Bodies[0]; //assume sun is 1st body in list
            this._currentState = new StateDocked();
            Hull = new ComponentHull(100,10);
            Scanner = new ComponentScanner(1);
            Engines = new ComponentEngines(10);
            _credits = 1000;
            Fuel = Hull.MaxFuel;
            this._durability = Hull.HullDurability;
        }

        public void ChangeState(IShipState state)
        {
            _currentState = state;
        }

        public List<IAction> GetActionList()
        {
            return _currentState.GetActions(this);
        }

        public Result PerformAction(IAction action)
        {
            return action.Execute(this);
        }

        public void AddCredits(double credits)
        {
            this._credits += credits;
        }
        public bool RemoveCredits(double credits)
        {
            if (this._credits >= credits)
            {
                this._credits -= credits;
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}
