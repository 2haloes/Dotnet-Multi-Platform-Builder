using Dotnet_Multi_Platform_Builder.Classes;
using System;

namespace Dotnet_Multi_Platform_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic OSinfo;


            Console.WriteLine("Downloading JSON...");
            WebFunctions webHelper = new WebFunctions();

            try
            {
                OSinfo = webHelper.DownloadJsonOSList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Download failed");
            }
            

            Console.WriteLine("Downloaded successfully!");

            Console.ReadKey();
        }
    }
}
