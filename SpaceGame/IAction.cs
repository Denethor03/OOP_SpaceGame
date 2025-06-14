using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal interface IAction
    {
        public string Name { get; }
        Result Execute(Ship ship);
    }
}
