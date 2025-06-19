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
            Console.WriteLine(@"
              _________                             ________                       
             /   _____/__________    ____  ____    /  _____/_____    _____   ____  
             \_____  \\____ \__  \ _/ ___\/ __ \  /   \  ___\__  \  /     \_/ __ \ 
             /        \  |_> > __ \\  \__\  ___/  \    \_\  \/ __ \|  Y Y  \  ___/ 
            /_______  /   __(____  /\___  >___  >  \______  (____  /__|_|  /\___  >
                    \/|__|       \/     \/    \/          \/     \/      \/     \/ 

            ");

            userInterface = new UI();
            int size = userInterface.SelectSize();
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
