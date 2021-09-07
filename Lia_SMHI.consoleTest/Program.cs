using System;
using System.Threading.Tasks;
using ZignSec.Integrations.SMHI.Gateway.Services;
using ZignSec.Integrations.SMHI.Gateway.Services.Models;

namespace Lia_SMHI.consoleTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SMHIClientSettings settings = new SMHIClientSettings();
            SMHIClient client = new SMHIClient(settings);

            SMHIRequest request = new SMHIRequest("strang1g", "1", "/geotype/point/lon/18.035631/lat/59.245956/parameter/118/data.json");
            Query? query = new Query(DateTime.Now.AddDays(-1), DateTime.Now);


            string result = await client.SendRequestAsync(request, query);

            Console.WriteLine(result);
        }
    }
}
