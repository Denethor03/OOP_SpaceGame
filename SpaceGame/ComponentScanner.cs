using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class ComponentScanner : Component
    {

        public double ScannerQuality { get; }
        public ComponentScanner(float scanQuality)
        {
            this.ScannerQuality = scanQuality;
            this.Name = $"Sensor Array (Quality: x{scanQuality:F2})";
            this.Description = $"Increases the value of all scanned data by {((scanQuality - 1.0f) * 100):F0}%.";
            this.Price = 500 + (int) Math.Pow(scanQuality, 4) * 500;
            this.Mass = 2 * scanQuality+4;
        }
    }
}
