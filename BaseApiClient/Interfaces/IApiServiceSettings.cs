namespace BaseApiClient.Interfaces
{
    public interface IApiServiceSettings
    {
        public string EndpointUri { get; set; }

        public string ContentType { get; set; }

        public int MaxTimeout { get; set; }

        public string? ProxyUri { get; set; }

        public int? ProxyPort { get; set; }
    }
}