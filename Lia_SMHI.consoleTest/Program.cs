using System;
using ZignSec.Integrations.SMHI.Gateway.Services;

namespace Lia_SMHI.consoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var settings = new SMHIClientSettings();
            var client = new SMHIClient(settings);
        }
    }
}
