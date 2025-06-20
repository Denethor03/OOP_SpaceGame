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
                $" at system {ship.CurrentSystem.Name} {ship.CurrentSystem.SystemCoords:F1}\n" +
                $"Ship mass: {ship.Engines.Mass+ship.Hull.Mass+ship.Scanner.Mass:F1}\n" +
                $"Current fuel: {ship.Fuel:F1}\n" +
                $"Max fuel: {ship.Hull.MaxFuel:F1}\n" +
                $"Current credits: {ship.Credits:F1}\n" +
                $"Scanned data value: {ship.ScanReward:F1}\n" +
                $"Current hull durability: {ship.Durability:F1}\n" +
                $"Max hull durability: {ship.Hull.HullDurability:F1}\n" +
                $"Jump range: {ship.Engines.JumpRange:F1} light years\n" +
                $"Scanner quality: {ship.Scanner.ScannerQuality:F1}\n");
        }
        
    }
}
