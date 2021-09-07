using ZignSec.Integrations.SMHI.Gateway.Services.Models;

namespace ZignSec.Integrations.SMHI.Gateway
{
    public interface ISMHIRequest
    {
        string Category { get; }
        string Version { get; }
        string Endpoint { get; }

        string GetRequestUri(IQuery query);
    }
}