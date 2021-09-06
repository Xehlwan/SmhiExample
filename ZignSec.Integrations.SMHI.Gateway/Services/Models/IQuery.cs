using System.Collections.Generic;

namespace ZignSec.Integrations.SMHI.Gateway.Services.Models
{
    public interface IQuery
    {
        IDictionary<string, string> GetQueryParams();
    }
}
