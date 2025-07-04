﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class BodyStation : Body
    {
        public List<Component> Stock {  get; private set; }
        public double ScanRewardModifier { get; private set; }
        public bool HasShipyard { get; }
        public int TechLevel { get; }
        public BodyStation(string name, Vector3 coords,TemplateStation stationTemplate) : base(name, true, coords,0, stationTemplate.Description)
        {
            Stock = new List<Component>();
            ScanRewardModifier = stationTemplate.ScanRewardModifier;
            HasShipyard = stationTemplate.HasShipyard;
            TechLevel = stationTemplate.TechLevel;
        }
        public void setStock(List<Component> components)
        {
            this.Stock = components;
        }
    }
}
