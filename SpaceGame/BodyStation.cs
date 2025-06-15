using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class BodyStation : Body
    {
        public BodyStation(string name, Vector3 coords) : base(name, true, coords,0) { }     
    }
}
