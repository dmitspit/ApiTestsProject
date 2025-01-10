using BaseApiClient.Builders;
using BaseApiClient.Interfaces;

using Microsoft.Extensions.Options;

using System.Text;

namespace BaseApiClient
{
    public class BaseApiService : IServiceClient
    {
        protected ApiClient apiClient;

        public string BaseUri { get; set; }

        public BaseApiService(IOptionsMonitor<IApiServiceSettings> serviceSettings)
        {
            ApiClientBuilder builder = new ApiClientBuilder(new Uri(serviceSettings.CurrentValue.EndpointUri))
               .WithEncoding(Encoding.UTF8)
               .WithContentType(serviceSettings.CurrentValue.ContentType)
               .WithMaxTimeout(serviceSettings.CurrentValue.MaxTimeout);

            if (serviceSettings.CurrentValue.ProxyPort is not null && serviceSettings.CurrentValue.ProxyUri is not null)
            {
                builder.WithProxy(serviceSettings.CurrentValue.ProxyUri, serviceSettings.CurrentValue.ProxyPort.Value);
            }

            this.apiClient = builder.Build();

            this.BaseUri = serviceSettings.CurrentValue.EndpointUri;
        }
    }
}
