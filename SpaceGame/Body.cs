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
        private Vector3 _coordinates;
        private bool canLand;
        private string description;
        private bool scanned = false;
        public string Description { get => description; }
        public int scanValue { get;  }
        public string Name { get => name; }
        
        public bool Scanned { get=> scanned; set=> scanned = value; }
        public Vector3 Coordinates { get=>_coordinates; }
       


        public Body(string name,
            bool canLand, Vector3 coordinates, int scanValue,string description)
        {
            this.name = name;
            this.canLand = canLand;
            this._coordinates = coordinates;
            this.scanValue = scanValue;
            this.description = description;
          
        }

    }
}
