﻿using RogueliteSurvivor.Components;
using RogueliteSurvivor.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueliteSurvivor.Utils
{
    public struct GameSettings
    {
        public Spells StartingSpell { get; set; }
        public string PlayerTexture { get; set; }
    }
}