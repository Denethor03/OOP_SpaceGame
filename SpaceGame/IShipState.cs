﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal interface IShipState
    {
        List<IAction> GetActions(Ship ship);
    }
}
