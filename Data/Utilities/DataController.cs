using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using System.IO;

namespace EndPointGuiTest.Data
{
    public class DataController
    {
        public RunResult getResult()
        {
            string JsonResult = File.ReadAllText(@"C:\Users\jpsmi\Desktop\EndpointDataResultSample.json");
            RunResult runResult = JsonConvert.DeserializeObject<RunResult>(JsonResult);

            return runResult;
        }
    }
}
