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
        public void Run()
        {
            userInterface = new UI();
            int size = userInterface.SelectSize();
            
            FactoryPlanet planetFactory = new FactoryPlanet();
            FactoryStation stationFactory = new FactoryStation();
            FactorySystem systemFactory = new FactorySystem(planetFactory,stationFactory);
            
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
