using RestSharp;

namespace BaseApiClient
{
    public class ApiClient : RestClient
    {
        public ApiClient(RestClientOptions options) : base(options)
        {
        }

        public string AuthToken
        {
            get
            {
                var auth = this.Authenticator as BaseOathAuthenticator;
                return auth.AuthToken;
            }
        }
    }
}
