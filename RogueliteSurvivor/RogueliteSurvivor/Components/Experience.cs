﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueliteSurvivor.Components
{
    public struct Experience
    {
        public Experience(int amount) 
        {
            Amount = amount;
        }
        public int Amount { get; set; }
    }
}
