using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class FactoryStation : FactoryBody
    {
        private readonly Random _random = new Random();
        public override BodyStation CreateBody(string systemName, int number, int orbitDistance)
        {
            int templateIndex = _random.Next(0, Parameters.StationTemplates.Count);

            TemplateStation selectedTemplate = Parameters.StationTemplates[templateIndex];

            string name = $"{selectedTemplate.FactionTypeName}";
            string desctiption = selectedTemplate.Description;
            Vector3 position = new Vector3(orbitDistance, 0, 0);
            

            var station = new BodyStation(name, position, selectedTemplate);

            return station;
        }
    }
}
