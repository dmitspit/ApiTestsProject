using BaseApiClient.Interfaces;

namespace HarryPotterApiService.Configurations
{
    public class HarryPotterServiceSettings : IApiServiceSettings
    {
        public string EndpointUri { get; set; } = string.Empty;

        public string ContentType { get; set; } = string.Empty;

        public int MaxTimeout { get; set; }

        public string? ProxyUri { get; set; }

        public int? ProxyPort { get; set; }
    }
}
