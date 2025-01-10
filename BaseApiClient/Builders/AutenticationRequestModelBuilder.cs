using BaseApiClient.Models.Authentication;

namespace BaseApiClient.Builders
{
    public class AutenticationRequestModelBuilder
    {
        private AuthenticationRequestModel model;

        public AutenticationRequestModelBuilder()
        {
            this.model = new AuthenticationRequestModel();
        }

        public AutenticationRequestModelBuilder WithClientId(string clientId) 
        {
            this.model.ClientId = clientId;
            return this;
        }

        public AutenticationRequestModelBuilder WithClientSecret(string secret) 
        {
            this.model.ClientSecret = secret;
            return this;
        }

        public AutenticationRequestModelBuilder WithUserName(string userName)
        {
            this.model.UserName = userName;
            return this;
        }

        public AutenticationRequestModelBuilder WithPassword(string password) 
        {
            this.model.Password = password;
            return this;
        }

        public AutenticationRequestModelBuilder WithScope(string scope) 
        {
            this.model.Scope = scope;
            return this;
        }

        public AuthenticationRequestModel Build() 
        {
            return this.model;
        }
    }
}
