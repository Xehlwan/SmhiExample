using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ZignSec.Integrations.SMHI.Gateway.Services.Models;

namespace ZignSec.Integrations.SMHI.Gateway.Services
{
    public class SMHIClient : ISMHIClient
    {
        ISMHIClientSettings _settings;
        HttpClient _httpClient;

        public string BaseUrl => _settings.BaseUrl;

        public SMHIClient(ISMHIClientSettings settings)
        {
            _settings = settings;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_settings.BaseUrl);
        }

        public async Task<string> SendRequestAsync(ISMHIRequest request, IQuery query)
        {
            var requestUri = request.GetRequestUri(query);
            var response = await _httpClient.GetAsync(requestUri);
            return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : "";
        }


    }
}
