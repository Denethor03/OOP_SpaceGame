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
        private string desctiption;
        public string Desctiption { get => desctiption; }
        public BodyPlanet(string name, Vector3 coords, bool canLand, string descrtiption,int scanValue) : base(name, canLand, coords,scanValue)
        {
            this.desctiption = descrtiption;
        }
    }
}
