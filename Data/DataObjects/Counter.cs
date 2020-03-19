using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPointGuiTest.Data
{
    public class Counter
    {
        public int second { get; set; }
        public string feature { get; set; }
        public string scenario { get; set; }
        public string step { get; set; }
        public double processcpu { get; set; }
        public int iowrite { get; set; }
        public int ioread { get; set; }
        public double processram { get; set; }
        public double swapram { get; set; }
        public double systemram { get; set; }
        public double systemcpu { get; set; }
    }
}
