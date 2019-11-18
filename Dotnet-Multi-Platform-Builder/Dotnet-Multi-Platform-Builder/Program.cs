using Dotnet_Multi_Platform_Builder.Classes;
using System;
using System.Collections.Generic;

namespace Dotnet_Multi_Platform_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Runtimes OSinfo;
            List<string> test = new List<string>();


            Console.WriteLine("Downloading JSON...");
            WebFunctions webHelper = new WebFunctions();
            // The path of the JSON object has the OS names to be used
            try
            {
                OSinfo = webHelper.DownloadJsonOSList();
                foreach (var item in OSinfo.OSList)
                {
                    test.Add(item.Path);
                    if (!item.Path.Contains("['"))
                    {
                        Console.WriteLine(item.Path);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Download failed");
            }
            finally
            {
                Console.WriteLine("Downloaded successfully!");
            }
            
            Console.ReadKey();
        }
    }
}
