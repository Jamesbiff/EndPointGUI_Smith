using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPointGuiTest.Data
{
    public class Feature
    {
        public string Name { get; set; }
        public int Status { get; set; }
        public double Duration { get; set; }
        public List<Scenario> Scenarios { get; set; }
    }
}
