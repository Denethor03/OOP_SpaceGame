using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal abstract class BodyFactory
    {
        public abstract Body CreateBody(Parameters parameters);
    }
}
