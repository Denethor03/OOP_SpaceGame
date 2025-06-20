using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SpaceGame
{
    internal class BodyStar : Body
    {
        public bool CanRefuel { get; }
        public double DamageModifier { get; }
        public BodyStar(string name, Vector3 coords, bool canLand,
            string descrtiption, int scanValue, bool canRefuel,double damageModifier) : 
            base(name, canLand, coords, scanValue, descrtiption)
        {
            CanRefuel = canRefuel;
            DamageModifier = damageModifier;
        }
    }
}
