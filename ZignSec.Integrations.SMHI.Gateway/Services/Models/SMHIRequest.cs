using System.Text;

namespace ZignSec.Integrations.SMHI.Gateway.Services.Models
{
    public class SMHIRequest : ISMHIRequest
    {
        public string Category { get; }
        public string Version { get; }
        public string Endpoint { get; }

        public SMHIRequest(string category, string version, string endpoint)
        {
            Category = category;
            Version = version;
            Endpoint = $"/api/category/{category}/version/{version}{endpoint}";
        }

        public string GetRequestUri(IQuery query)
        {
            var sb = new StringBuilder();
            sb.Append(Endpoint);
            sb.Append('?');
            foreach (var kvp in query.GetQueryParams())
            {
                sb.Append(kvp.Key);
                sb.Append('=');
                sb.Append(kvp.Value);
                sb.Append('&');
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
    }
}
