using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class StarSystem
    {
        private string name;
        private List<Body> bodies = new();
        private Vector3 systemCoords = new();

        public string Name { get => name; }

        public List<Body> Bodies { get => bodies; }
        public Vector3 SystemCoords {get => systemCoords;}

        public StarSystem(string name, List<Body> bodies, Vector3 systemCoords)
        {
            this.name = name;
            this.bodies = bodies;
            this.systemCoords = systemCoords;
        }

        public void AddBody(Body body)
        {
            bodies.Add(body);
        }
    }
}
