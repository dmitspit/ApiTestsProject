using BaseApiClient.Models.Authentication;

using RestSharp;
using System.Net;
using System.Text;

namespace BaseApiClient.Builders
{
    public class ApiClientBuilder
    {
        private ApiClient apiClient;

        public ApiClientBuilder(Uri baseUri)
        {
            this.apiClient = new ApiClient(new RestClientOptions(baseUri));
        }

        public ApiClientBuilder()
        {
            this.apiClient = new ApiClient(new RestClientOptions());
        }

        public ApiClientBuilder WithMaxTimeout(int maxTimeout)
        {
            this.apiClient.Options.MaxTimeout = maxTimeout;
            return this;
        }

        public ApiClientBuilder WithEncoding(Encoding encoding)
        {
            this.apiClient.Options.Encoding = encoding;
            return this;
        }

        public ApiClientBuilder WithContentType(string contentType)
        {
            this.apiClient.AcceptedContentTypes.Append(contentType);
            return this;
        }

        public ApiClientBuilder WithCredentials(string authPath, string clientId, string clientSecret)
        {
            this.apiClient.Authenticator =
                new BaseOauthAuthenticator(this.apiClient.Options.BaseUrl, authPath, clientId, clientSecret);
            return this;
        }

        public ApiClientBuilder WithAuthorizationData(string authPath, AuthenticationRequestModel authorizationModel)
        {
            this.apiClient.Authenticator =
                new OAuthAuthenticator(this.apiClient.Options.BaseUrl, authPath, authorizationModel);
            return this;
        }

        public ApiClientBuilder WithProxy(Uri proxyUri)
        {
            this.apiClient.Options.Proxy = new WebProxy(proxyUri);
            return this;
        }

        public ApiClientBuilder WithProxy(string host, int port)
        {
            this.apiClient.Options.Proxy = new WebProxy(host, port);
            return this;
        }

        public ApiClient Build()
        {
            return this.apiClient;
        }
    }
}
