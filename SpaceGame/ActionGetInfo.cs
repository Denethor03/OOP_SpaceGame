using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ActionGetInfo : IAction
    {   
        public string Name => "Get Information";
        public Result Execute(Ship ship)
        {
            return new Result($"Current location:" +
                $"{ship.CurrentBody.Name} {ship.CurrentBody.Coordinates}" +
                $" at system {ship.CurrentSystem.Name} {ship.CurrentSystem.SystemCoords}\n" +
                $"Current fuel: {ship.Fuel}\n" +
                $"Max fuel: {ship.Hull.MaxFuel}\n" +
                $"Current credits: {ship.Credits}\n" +
                $"Scanned data value: {ship.ScanReward}\n" +
                $"Current hull durability: {ship.Hull.HullDurability}\n" +
                $"Max hull durability: {ship.Hull.HullDurability}\n" +
                $"Jump range: {ship.Engines.JumpRange} light years\n" +
                $"Scanner quality: {ship.Scanner.ScannerQuality}\n");
        }
        
    }
}
