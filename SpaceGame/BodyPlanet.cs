using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class BodyPlanet : Body
    {
        
        public BodyPlanet(string name, Vector3 coords, bool canLand, string descrtiption,int scanValue) : base(name, canLand, coords,scanValue,descrtiption)
        {
            
        }
    }
}
