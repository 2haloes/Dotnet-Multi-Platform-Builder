using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Dotnet_Multi_Platform_Builder.Classes
{
    class WebFunctions
    {
        public HttpClient webClient { get; set; }

        // Should be set up the least number of times possible
        public WebFunctions()
        {
            webClient = new HttpClient();
        }

        public dynamic DownloadJsonOSList()
        {
            HttpResponseMessage response = webClient.GetAsync("https://raw.githubusercontent.com/dotnet/corefx/master/src/pkg/Microsoft.NETCore.Platforms/runtime.json").Result;
            Console.WriteLine("Gotten response!");
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                throw;
            }

            Console.WriteLine("Response good!");

            return JsonConvert.DeserializeObject<object>(response.Content.ReadAsStringAsync().Result);
        }
    }
}
