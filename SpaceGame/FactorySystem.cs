using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class FactorySystem
    {

        private FactoryPlanet factoryPlanet;
        private FactoryStation stationFactory;
        private FactoryStar starFactory;
        private readonly Random _random = new Random();
        public FactorySystem(FactoryPlanet factoryPlanet, FactoryStation stationFactory,FactoryStar starFactory)
        {
            this.factoryPlanet = factoryPlanet;
            this.stationFactory = stationFactory;
            this.starFactory = starFactory;
        }

        public List<StarSystem> CreateSystem(int size)
        {
            List<StarSystem> starSystems = new List<StarSystem>();

            for (int i = 0; i < size; i++)
            {
                
                string sysNameSuffix = Parameters.SystemNameSuffixes[_random.Next(0, Parameters.SystemNameSuffixes.Count)];
                string sysNamePrefix = Parameters.SystemNamePrefixes[_random.Next(0, Parameters.SystemNamePrefixes.Count)];
                int maxPlanets = _random.Next(3, 15);
                string systemFullName = $"{sysNamePrefix} {sysNameSuffix}";
                Vector3 sysCoords = new Vector3(_random.Next(0,20),_random.Next(0,20),_random.Next(0,20));
                List<Body> sysBodies = new List<Body>();
                var star = starFactory.CreateBody(sysNamePrefix, 0, 0);
                sysBodies.Add(star);
                for (int j = 0; j < maxPlanets; j++)
                {
                    var planet = factoryPlanet.CreateBody(systemFullName, j + 1, 10*j + _random.Next(1, 9));
                    sysBodies.Add(planet);
                    if (_random.NextDouble() < 0.25)
                    {
                        var station = stationFactory.CreateBody(systemFullName, 0, 10 * j + _random.Next(1, 9));
                        sysBodies.Add(station);
                    }
                }
                
                StarSystem starSystem = new StarSystem(systemFullName,sysBodies,sysCoords);
                starSystems.Add(starSystem);
            }

            return starSystems;
        }
    }
}
