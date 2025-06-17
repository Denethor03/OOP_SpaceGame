using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class FactoryPlanet : FactoryBody
    {
        private readonly Random _random = new Random();

        public override BodyPlanet CreateBody(string systemName, int number, int orbitDistance)
        {
            int templateIndex = _random.Next(0, Parameters.planetTemplates.Count);
            
            TemplatePlanet selectedTemplate = Parameters.planetTemplates[templateIndex];

            string name = $"{systemName}-{number} {selectedTemplate.TypeName}";
            string desctiption = selectedTemplate.Description;
            Vector3 position = new Vector3(orbitDistance, 0, 0);
            int scanValue = _random.Next(selectedTemplate.MinScanReward,selectedTemplate.MaxScanReward+1);
            
            var planet = new BodyPlanet(name, position, selectedTemplate.Landable, desctiption,scanValue);
            
            return planet;
        }
    }
}
