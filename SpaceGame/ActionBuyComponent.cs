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
            if (!ship.RemoveCredits(_component.Price))
            {
                return new Result(false,"Not enough credits for purchase");
            }
            else
            {
                if(_component is ComponentHull hull)
                {
                    if (ship.Hull == hull) 
                    {
                        return new Result(false, "You already have this");
                    }
                    ship.Hull = hull;
                }
                if(_component is ComponentScanner scanner)
                {
                    if (ship.Scanner == scanner)
                    {
                        return new Result(false, "You already have this");
                    }
                    ship.Scanner = scanner;
                }
                if(_component is ComponentEngines engines)
                {
                    if (ship.Engines == engines)
                    {
                        return new Result(false, "You already have this");
                    }
                    ship.Engines = engines;
                }          
                return new Result("Component purchased succesfully");
            }
        }
    }
}
