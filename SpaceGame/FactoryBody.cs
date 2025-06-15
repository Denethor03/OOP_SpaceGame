using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal abstract class FactoryBody
    {
        public abstract Body CreateBody(string system, int number, int orbitDistance);
    }
}
