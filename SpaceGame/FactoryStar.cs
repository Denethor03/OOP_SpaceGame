using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class FactoryStar : FactoryBody
    {
        private readonly Random _random = new Random();

        public override BodyStar CreateBody(string systemName, int number, int orbitDistance)
        {
            int templateIndex = _random.Next(0, Parameters.StarTemplates.Count);

            TemplateStar selectedTemplate = Parameters.StarTemplates[templateIndex];

            string name = $"{systemName} {selectedTemplate.TypeName}";
            string desctiption = selectedTemplate.Description;
            Vector3 position = new Vector3(orbitDistance, 0, 0);
            int scanValue = _random.Next(selectedTemplate.MinScanReward, selectedTemplate.MaxScanReward + 1);

            var star = new BodyStar(name, position, false, desctiption,
                scanValue,selectedTemplate.CanRefuel,selectedTemplate.DamageModifier);

            return star;
        }
    }
}
