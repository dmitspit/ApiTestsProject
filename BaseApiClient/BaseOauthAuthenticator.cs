using System;
using System.Threading.Tasks;
using BaseApiClient.Models.Authentication;
using RestSharp;
using RestSharp.Authenticators;

namespace BaseApiClient
{
    public class BaseOauthAuthenticator : AuthenticatorBase
    {
        protected Uri baseUri;
        protected string clientId;
        protected string clientSecret;
        protected string resource;

        public string AuthToken 
        { 
            get => this.Token; 
        }

        public BaseOauthAuthenticator(Uri baseUri, string authResource, string clientId, string secret) : base("")
        {
            this.baseUri = baseUri;
            this.clientId = clientId;
            this.clientSecret = secret;
            this.resource = authResource;
        }
        
        public BaseOauthAuthenticator(string token) : base(token)
        {
        }

        protected override async ValueTask<Parameter> GetAuthenticationParameter(string accessToken)
        {
            this.Token = string.IsNullOrEmpty(this.Token) ? await this.GetToken() : this.Token;
            return new HeaderParameter(KnownHeaders.Authorization, this.Token);
        }

        public virtual async Task<string> GetToken()
        {
            var options = new RestClientOptions(this.baseUri);
            using var client = new RestClient(options)
            {
                Authenticator = new HttpBasicAuthenticator(this.clientId, this.clientSecret),
            };

            RestRequest request = new RestRequest(this.resource)
                .AddParameter("grant_type", "client_credentials");

            TokenResponseModel response = await client.PostAsync<TokenResponseModel>(request);
            return $"{response!.TokenType} {response!.AccessToken}";
        }
    }
}
