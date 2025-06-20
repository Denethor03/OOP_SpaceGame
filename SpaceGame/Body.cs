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
        private bool _canLand;
        private string _description;
        private bool _scanned = false;
        public string Description { get => _description; }
        public int ScanValue { get;  }
        public string Name { get => name; }
        
        public bool Scanned { get=> _scanned; set=> _scanned = value; }
        public Vector3 Coordinates { get=>_coordinates; }
        public bool CanLand => _canLand;
       


        public Body(string name,
            bool canLand, Vector3 coordinates, int scanValue,string description)
        {
            this.name = name;
            this._canLand = canLand;
            this._coordinates = coordinates;
            this.ScanValue = scanValue;
            this._description = description;
          
        }

    }
}
