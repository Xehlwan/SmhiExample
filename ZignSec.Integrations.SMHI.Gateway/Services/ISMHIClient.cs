using System.Threading.Tasks;
using ZignSec.Integrations.SMHI.Gateway.Services.Models;

namespace ZignSec.Integrations.SMHI.Gateway
{
    public interface ISMHIClient
    {
        string BaseUrl { get; }

        Task<string> SendRequestAsync(ISMHIRequest request, IQuery query);
    }
}