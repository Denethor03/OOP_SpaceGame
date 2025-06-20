using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class Game
    {
        private Universe? gameWorld;
        public UI? userInterface;
        private Ship? ship;
        private static readonly int MaxGameSize = 200;
        private static readonly int MinGameSize = 3;
        public void Run()
        {
            userInterface = new UI();
            userInterface.WelcomeMessage();
            int size = userInterface.SelectSize(MaxGameSize,MinGameSize);
            Console.Clear();
            FactoryPlanet planetFactory = new FactoryPlanet();
            FactoryStation stationFactory = new FactoryStation();
            FactoryStar starFactory = new FactoryStar();
            FactorySystem systemFactory = new FactorySystem(planetFactory,stationFactory,starFactory);
            
            List<StarSystem> starSystems = systemFactory.CreateSystem(size);
            gameWorld = new Universe(starSystems);
            
            Ship ship = new Ship(gameWorld);
           
            Console.WriteLine("Game started");
            
            List<IAction> actions = ship.GetActionList();

            while (true)
            {
                IAction selectedAction = userInterface.ChooseAction(actions);
                Result result = ship.PerformAction(selectedAction);
                userInterface.DisplayResult(result);

                if (result.followUpActions.Any())
                {
                    actions = result.followUpActions;
                }
                else
                {
                    actions = ship.GetActionList();
                }
            }
      
        }
    }
}
