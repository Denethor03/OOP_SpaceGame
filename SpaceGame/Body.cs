using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal abstract class Body
    {
        private string name;
        private Vector3 Coordinates;
        private bool CanLand;
        public int scanValue { get; protected set; }
        public string Name { get => name; set => name = value; }
       


        public Body(string name,
            bool canLand, Vector3 coordinates)
        {
            this.name = name;
            this.CanLand = canLand;
            this.Coordinates = coordinates;
          
        }

    }
}
