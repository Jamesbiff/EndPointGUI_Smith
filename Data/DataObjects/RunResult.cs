using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;

namespace EndPointGuiTest.Data
{
    public class RunResult
    {
        public string MachineName { get; set; }
        public bool Status { get; set; }
        public List<Feature> Features { get; set; }
        public List<Counter> Counters { get; set; }
    }
}
