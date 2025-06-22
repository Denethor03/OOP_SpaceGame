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
        public StarSystem LastStarSystem { get; private set; }
        public Body LastStation { get; private set; }

        private double _fuel;
        private double _durability;
        public double Durability => _durability;
        public ComponentHull Hull { get; set; }
        public ComponentEngines Engines { get; set; }
        public ComponentScanner Scanner { get; set; }
    
        public double ScanReward { get => _scanReward; set => _scanReward = value; }
        public double Fuel 
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
            this._currentState = new StateDocked();
            Hull = new ComponentHull(100,10);
            Scanner = new ComponentScanner(1);
            Engines = new ComponentEngines(10);
            _credits = 1000000;
            Fuel = Hull.MaxFuel;
            this._durability = Hull.HullDurability;
            foreach (var system in universe.starSystems)
            {
                
                foreach (var body in system.Bodies)
                {
                    if (body is BodyStation station)
                    {
                        _currentSystem = system;
                        LastStarSystem = system;
                        _currentBody = station;
                        LastStation = station;
                        return;
                    }
                }
            }
            // in case no station is found (very unlikely)
            _currentSystem = universe.starSystems[0];
            LastStarSystem = _currentSystem;
            _currentBody = _currentSystem.Bodies[0];
            LastStation = _currentBody;
            _currentState = new StateOrbitingBody();
                
            
        }

        public void ChangeState(IShipState state)
        {
            _currentState = state;
            if(state is StateDocked && CurrentBody is BodyStation )
            {
                LastStation = CurrentBody;
                LastStarSystem = CurrentSystem;
            }
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
        public bool TakeDamage(double damage)
        {
            if(damage >= _durability)
            {
                HandleDestruction();
                return false;
            }
            else
            {
                _durability -= damage;
                return true;
            }
        }
        public void Repair()
        {
            _durability = Hull.HullDurability;
        }
        public void HandleDestruction()
        {
            double insuranceCost = (Hull.Price + Engines.Price + Scanner.Price)/20;
            if(!RemoveCredits(insuranceCost))
            {
                Hull = new ComponentHull(100, 10); //in case of not enough credits for insurance
                Scanner = new ComponentScanner(1); //components are replaced with "basic" ones
                Engines = new ComponentEngines(10);
                _durability = Hull.HullDurability;
                CurrentBody = LastStation;
                CurrentSystem = LastStarSystem;
                _currentState = new StateDocked();
            }
            else
            {
                CurrentBody = LastStation;
                CurrentSystem = LastStarSystem;
                _durability = Hull.HullDurability;
                _currentState = new StateDocked();

            }
        }
       
    }
}
