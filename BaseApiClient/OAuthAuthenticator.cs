using BaseApiClient.Models.Authentication;
using RestSharp;
using RestSharp.Authenticators;

namespace BaseApiClient
{
    public class OAuthAuthenticator : BaseOathAuthenticator
    {
        private AuthenticationRequestModel authenticationData;

        public OAuthAuthenticator(string token) : base(token)
        {
        }

        public OAuthAuthenticator(Uri baseUri, string authPath, AuthenticationRequestModel requestModel) : base("")
        {
            this.authenticationData = requestModel;
            this.baseUri = baseUri;
            this.resource = authPath;
        }

        public override async Task<string> GetToken()
        {
            var options = new RestClientOptions(this.baseUri);
            using var client = new RestClient(options)
            {
                Authenticator = new HttpBasicAuthenticator(this.clientId, this.clientSecret),
            };

            RestRequest request = new RestRequest(this.resource, Method.Post)
                .AddHeader("Content-Type", "application/x-www-form-urlencoded")
                .AddParameter("grant_type", "password")
                .AddParameter("client_id", this.authenticationData.ClientId)
                .AddParameter("client_secret", this.authenticationData.ClientSecret)
                .AddParameter("username", this.authenticationData.UserName)
                .AddParameter("password", this.authenticationData.Password)
                .AddParameter("scope", this.authenticationData.Scope);

            TokenResponseModel response = await client.PostAsync<TokenResponseModel>(request);
            return $"{response!.TokenType} {response!.AccessToken}";
        }
    }
}
