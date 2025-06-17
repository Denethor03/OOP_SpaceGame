using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class FactoryComponent
    {
        private readonly Random _random = new Random();

        public List<Component> CreateStock(int techLevel)
        {
            var stock = new List<Component>();
            int stockSize = _random.Next(techLevel, techLevel * 2 + 1);
            for (int i = 0; i<stockSize; i++)
            {
                int compType = _random.Next(0, 3);
                switch (compType)
                {
                    case 0:
                        stock.Add(CreateHull(techLevel)); break;
                    case 1:
                        stock.Add(CreateScanner(techLevel)); break;
                    case 2:
                        stock.Add(CreateEngines(techLevel)); break;
                }
            }
            return stock;
        }

        public ComponentHull CreateHull(int techLevel)
        {
            int baseHp = 50 * techLevel;
            int randomBonus = _random.Next(0, 50 * techLevel);
            return new ComponentHull(100 + baseHp + randomBonus,10*techLevel);
        }

        public ComponentEngines CreateEngines(int techLevel)
        {
            int baseRange = 10 * techLevel;
            int randomBonus = _random.Next(0, 5 * techLevel);
            return new ComponentEngines(20 + baseRange + randomBonus);
        }

        public ComponentScanner CreateScanner(int techLevel)
        {
            float baseQuality = 0.10f * techLevel;
            float randomBonus = (float)_random.NextDouble() * 0.10f * techLevel;
            return new ComponentScanner(1.0f + baseQuality + randomBonus);
        }
    }
}
