using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class FactoryStation : FactoryBody
    {
        public override BodyStation CreateBody(string systemName,int number, int c)
        {
            return new BodyStation("asd",new System.Numerics.Vector3(1,1,1));
        }
    }
}
