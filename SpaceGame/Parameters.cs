using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static SpaceGame.TemplateStation;

namespace SpaceGame
{
    internal static class Parameters
    {
      
        
        public static readonly List<string> SystemNamePrefixes = new List<string>
        {
            "Kepler",      
            "Zeta",        
            "Orion",      
            "Rift",        
            "Corvus",      
            "Andromeda",   
            "Solitude",    
            "Dragon's",    
            "Hadley's",    
            "Typhon",      
            "Genesis",     
            "Vesper"       
        }; 
        public static readonly List<string> SystemNameSuffixes = new List<string>
        {
            "Expanse",
            "Nexus",
            "Terminus",
            "Reach",
            "Void",
            "Cluster",
            "Sanctuary",
            "Maw",
            "Hope",
            "Crucible",
            "Gate",
            "Abyss"
        };
        public static readonly List<string> StationNamePrefixes = new List<string>
        {
            "Port",
            "Fort",
            "Haven",
            "Deep",
            "Star",
            "Vanguard",
            "Omega",
            "Aegis",
            "Horizon",
            "Citadel",
            "Waypoint"
        };
        public static readonly List<TemplatePlanet> planetTemplates = new List<TemplatePlanet>
        {
            new TemplatePlanet
            {
                TypeName = "Barren Rock",
                Description = "A desolate, crater-pocked world battered by solar winds. Its thin atmosphere offers little protection from the harshness of space.",
                MinScanReward = 10,
                MaxScanReward = 50,
                Landable = true
            },
            new TemplatePlanet
            {
                TypeName = "Gas Giant",
                Description = "A colossal sphere of swirling hydrogen and helium. Its immense gravity has captured several small, icy moons in its orbit.",
                MinScanReward = 75,
                MaxScanReward = 200,
                Landable = false
            },
            new TemplatePlanet
            {
                TypeName = "Volcanic World",
                Description = "A geologically young and violent planet, where rivers of molten rock carve paths across a surface of black, volcanic glass.",
                MinScanReward = 60,
                MaxScanReward = 180,
                Landable = false
            },
            new TemplatePlanet
            {
                TypeName = "Ocean Planet",
                Description = "A world almost entirely covered by a single, globe-spanning ocean. Strange, bioluminescent creatures are said to dwell in its crushing depths.",
                MinScanReward = 200,
                MaxScanReward = 500,
                Landable = false
            },
            new TemplatePlanet
            {
                TypeName = "Ice World",
                Description = "A frozen sphere locked in a perpetual winter. Glaciers of nitrogen and methane grind slowly across its frigid surface.",
                MinScanReward = 40,
                MaxScanReward = 120,
                Landable = true
            },
            new TemplatePlanet
            {
                TypeName = "Jungle Planet",
                Description = "A humid, hothouse world teeming with hyper-aggressive flora and fauna. The air is thick with spores and the buzz of unseen insects.",
                MinScanReward = 250,
                MaxScanReward = 600,
                Landable = true
            },
            new TemplatePlanet
            {
                TypeName = "Crystalline World",
                Description = "A geological anomaly where massive, crystalline structures grow from the ground like forests, refracting the light of the local star.",
                MinScanReward = 500,
                MaxScanReward = 1200,
                Landable = true
            },
            new TemplatePlanet
            {
                TypeName = "Desert Planet",
                Description = "Scorched by its twin suns, this arid world is a vast expanse of dunes and wind-swept canyons. Water is more valuable than gold here.",
                MinScanReward = 30,
                MaxScanReward = 100,
                Landable = true
            },
            new TemplatePlanet
            {
                TypeName = "Shattered Remnant",
                Description = "The graveyard of a long-dead planet. A field of orbiting asteroids and debris is all that remains of its ancient catastrophe.",
                MinScanReward = 150,
                MaxScanReward = 400,
                Landable = true
            },
            new TemplatePlanet
            {
                TypeName = "Terraformed Paradise",
                Description = "An engineered world with perfectly balanced ecosystems and a breathable atmosphere. It represents a colossal investment by a forgotten corporation.",
                MinScanReward = 700,
                MaxScanReward = 1500,
                Landable = true
            },
            new TemplatePlanet
            {
                TypeName = "Toxic Smogball",
                Description = "A planet choked by a thick, corrosive atmosphere of sulfur and acid. Its surface is permanently hidden beneath a veil of poisonous yellow clouds.",
                MinScanReward = 5,
                MaxScanReward = 25,
                Landable = false
            }
        };
        public static readonly List<TemplateStar> StarTemplates = new List<TemplateStar>
        {
             new TemplateStar
            {
                TypeName = "G-Type Main-Sequence (Yellow Dwarf)",
                Description = "A stable, yellow star. Its predictable solar winds allow for relatively safe fuel scooping, but the process still puts a strain on ship systems.",
                CanRefuel = true,
                DamageModifier = 1.0f,
                MinScanReward = 100,
                MaxScanReward = 250
            },
            new TemplateStar
            {
                TypeName = "M-Type Main-Sequence (Red Dwarf)",
                Description = "A dim, ancient star. Its gentle stellar winds make it the safest star type for emergency refueling, causing minimal component stress.",
                CanRefuel = true,
                DamageModifier = 0.25f,
                MinScanReward = 50,
                MaxScanReward = 100
            },
            new TemplateStar
            {
                TypeName = "O-Type Supergiant (Blue Giant)",
                Description = "A terrifyingly hot and massive star. Scooping fuel here is an act of desperation, as its fierce solar winds will batter the ship.",
                CanRefuel = true,
                DamageModifier = 2.5f,
                MinScanReward = 1000,
                MaxScanReward = 2500
            },
            new TemplateStar
            {
                TypeName = "White Dwarf",
                Description = "The dying, super-dense core of a long-dead star. While its gravitational field is intense, its stellar output is too weak for refueling.",
                CanRefuel = false,
                DamageModifier = 0.0f,
                MinScanReward = 300,
                MaxScanReward = 600
            },
            new TemplateStar
            {
                TypeName = "Pulsar (Neutron Star)",
                Description = "A rapidly spinning stellar corpse sweeping beams of intense radiation across the system. Attempting to refuel here is suicide.",
                CanRefuel = false,
                DamageModifier = 0.0f,
                MinScanReward = 2000,
                MaxScanReward = 5000 
            },
            new TemplateStar
            {
                TypeName = "K-Type Main-Sequence (Orange Dwarf)",
                Description = "A calm orange star, slightly cooler than its yellow cousins. It is a highly desirable refueling point, causing little wear on components.",
                CanRefuel = true,
                DamageModifier = 0.5f,
                MinScanReward = 150,
                MaxScanReward = 350
            }
        };
        public static readonly List<TemplateStation> StationTemplates = new List<TemplateStation>
        {
            new TemplateStation
            {
                FactionTypeName = "Corporate Trade Hub",
                Description = "A bustling, clean station operated by a major corporation. Commerce flows freely, but everything has a price.",
                HasShipyard = true,
                TechLevel = 4,
                ScanRewardModifier = 1.15f
            },
            new TemplateStation
            {
                FactionTypeName = "Federation Military Base",
                Description = "A spartan, heavily-armored battlestation. It offers high-quality ship services to allies, but is wary of unknown vessels.",
                HasShipyard = true,
                TechLevel = 5,
                ScanRewardModifier = 1.0f 
            },
            new TemplateStation
            {
                FactionTypeName = "Independent Mining Depot",
                Description = "A grimy, utilitarian outpost built into an asteroid. It's a rough place, but fuel is cheap and no one asks too many questions.",
                HasShipyard = true,
                TechLevel = 2, 
                ScanRewardModifier = 0.85f 
            },
            new TemplateStation
            {
                FactionTypeName = "Scientific Research Post",
                Description = "A quiet, isolated laboratory dedicated to stellar phenomena. While they don't offer many services, they pay top dollar for unique scan data.",
                HasShipyard = false, 
                TechLevel = 0,
                ScanRewardModifier = 1.0f
            },
            new TemplateStation
            {
                FactionTypeName = "Smuggler's Den",
                Description = "A hidden station operating in the shadows of the law. Services are limited and prices are steep, but they sometimes stock rare or illegal ship components.",
                HasShipyard = true,
                TechLevel = 3, 
                ScanRewardModifier = 1.75f 
            }
        };
    }
}
