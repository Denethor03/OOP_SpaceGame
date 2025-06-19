using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionBuyComponent : IAction
    {
        public string Name { get; set; }
        private Component _component;
        public ActionBuyComponent(Component component)
        {
            Name = $"{component.Name}\n" +
                $"{component.Description}\n" +
                $"Cost: {component.Price} credits";
            _component = component;
        }

        public Result Execute(Ship ship)
        {
            if (ship.Credits < _component.Price)
            {
                return new Result("Not enough credits for purchase");
            }
            else
            {
                if(_component is ComponentHull hull)
                {
                    ship.Hull = hull;
                }
                if(_component is ComponentScanner scanner)
                {
                    ship.Scanner = scanner;
                }
                if(_component is ComponentEngines engines)
                {
                    ship.Engines = engines;
                }
                ship.RemoveCredits(_component.Price);
                return new Result("Component purchased succesfully");
            }
        }
    }
}
