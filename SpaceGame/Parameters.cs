using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal static class Parameters
    {
        //names and descriptions provided by LLM 
        
        public static readonly List<string> SystemNamePrefixes = new List<string>
        {
            "Kepler",      // Astronomical theme
            "Zeta",        // Greek letter theme
            "Orion",       // Constellation theme
            "Rift",        // Geographic/space feature theme
            "Corvus",      // Latin/mythological theme
            "Andromeda",   // Galaxy theme
            "Solitude",    // Evocative/mood theme
            "Dragon's",    // Fantasy/mythical theme
            "Hadley's",    // Possessive/discoverer theme
            "Typhon",      // Mythological monster theme
            "Genesis",     // Foundational/origin theme
            "Vesper"       // Time of day/mood theme
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
        public static readonly List<PlanetTemplate> planetTemplates = new List<PlanetTemplate>
        {
            new PlanetTemplate
            {
                TypeName = "Barren Rock",
                Description = "A desolate, crater-pocked world battered by solar winds. Its thin atmosphere offers little protection from the harshness of space.",
                MinScanReward = 10,
                MaxScanReward = 50,
                Landable = true
            },
            new PlanetTemplate
            {
                TypeName = "Gas Giant",
                Description = "A colossal sphere of swirling hydrogen and helium. Its immense gravity has captured several small, icy moons in its orbit.",
                MinScanReward = 75,
                MaxScanReward = 200,
                Landable = false
            },
            new PlanetTemplate
            {
                TypeName = "Volcanic World",
                Description = "A geologically young and violent planet, where rivers of molten rock carve paths across a surface of black, volcanic glass.",
                MinScanReward = 60,
                MaxScanReward = 180,
                Landable = false
            },
            new PlanetTemplate
            {
                TypeName = "Ocean Planet",
                Description = "A world almost entirely covered by a single, globe-spanning ocean. Strange, bioluminescent creatures are said to dwell in its crushing depths.",
                MinScanReward = 200,
                MaxScanReward = 500,
                Landable = false
            },
            new PlanetTemplate
            {
                TypeName = "Ice World",
                Description = "A frozen sphere locked in a perpetual winter. Glaciers of nitrogen and methane grind slowly across its frigid surface.",
                MinScanReward = 40,
                MaxScanReward = 120,
                Landable = true
            },
            new PlanetTemplate
            {
                TypeName = "Jungle Planet",
                Description = "A humid, hothouse world teeming with hyper-aggressive flora and fauna. The air is thick with spores and the buzz of unseen insects.",
                MinScanReward = 250,
                MaxScanReward = 600,
                Landable = true
            },
            new PlanetTemplate
            {
                TypeName = "Crystalline World",
                Description = "A geological anomaly where massive, crystalline structures grow from the ground like forests, refracting the light of the local star.",
                MinScanReward = 500,
                MaxScanReward = 1200,
                Landable = true
            },
            new PlanetTemplate
            {
                TypeName = "Desert Planet",
                Description = "Scorched by its twin suns, this arid world is a vast expanse of dunes and wind-swept canyons. Water is more valuable than gold here.",
                MinScanReward = 30,
                MaxScanReward = 100,
                Landable = true
            },
            new PlanetTemplate
            {
                TypeName = "Shattered Remnant",
                Description = "The graveyard of a long-dead planet. A field of orbiting asteroids and debris is all that remains of its ancient catastrophe.",
                MinScanReward = 150,
                MaxScanReward = 400,
                Landable = true
            },
            new PlanetTemplate
            {
                TypeName = "Terraformed Paradise",
                Description = "An engineered world with perfectly balanced ecosystems and a breathable atmosphere. It represents a colossal investment by a forgotten corporation.",
                MinScanReward = 700,
                MaxScanReward = 1500,
                Landable = true
            },
            new PlanetTemplate
            {
                TypeName = "Toxic Smogball",
                Description = "A planet choked by a thick, corrosive atmosphere of sulfur and acid. Its surface is permanently hidden beneath a veil of poisonous yellow clouds.",
                MinScanReward = 5,
                MaxScanReward = 25,
                Landable = false
            }
        };
    }
}
