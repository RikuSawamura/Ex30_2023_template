﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_2023_template
{
    internal class Refrigerator : ElectricAppliances
    {
        public Refrigerator(string n = null, float w = 0, float h = 0, float d = 0, float wei = 0) : base(n, w, h, d, wei)
        {

        }
    }
}
