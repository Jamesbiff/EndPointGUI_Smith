﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPointGuiTest.Data
{
    public class Scenario
    {
        public string Name { get; set; }
        public int Status { get; set; }
        public double Duration { get; set; }
        public List<Step> Steps { get; set; }
    }
}
