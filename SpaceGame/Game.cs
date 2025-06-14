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
        public UI? userInterface;
        public Body? station1, station2, station3;
        private Ship? ship;
        public StarSystem? starSystem;
        public void Run()
        {
            userInterface = new UI();
            station1 = new BodyStation("test_station", new Vector3(0, 0, 0));
            station2 = new BodyStation("jump_destinationA", new Vector3(1, 1, 1));
            station3 = new BodyStation("jump_destinationB", new Vector3(2, 2, 2));
            List<Body> bodies = new List<Body>();
            bodies.Add(station1);
            bodies.Add(station2);
            bodies.Add(station3);
            starSystem = new StarSystem("Starter system", bodies, new Vector3(0, 0, 0));
            ship = new Ship(starSystem);
            Console.WriteLine("Game started");
            
            List<IAction> actions = ship.GetActionList();

            while (true)
            {
                IAction selectedAction = userInterface.chooseAction(actions);
                Result result = ship.PerformAction(selectedAction);
                userInterface.displayResult(result);

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
