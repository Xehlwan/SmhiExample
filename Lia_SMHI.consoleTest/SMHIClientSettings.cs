using ZignSec.Integrations.SMHI.Gateway.Services.Models;

namespace Lia_SMHI.consoleTest
{
    internal class SMHIClientSettings : ISMHIClientSettings
    {

        public SMHIClientSettings()
        {
            BaseUrl = "https://opendata-download-metanalys.smhi.se";
        }

        public string BaseUrl {  get; set; }
    }
}
