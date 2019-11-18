using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnet_Multi_Platform_Builder.Classes
{
    public class OSDataStorage
    {
        
        public dynamic runtimes { get; set; }
    }

    public class Runtimes
    {
        [JsonProperty("runtimes")]
        public dynamic OSList { get; set; }
    }

    public class OSContent
    {
        [JsonProperty("#index")]
        public IList<string> index { get; set; }
    }
}
