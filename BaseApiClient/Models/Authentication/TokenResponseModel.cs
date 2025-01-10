using System.Text.Json.Serialization;

namespace BaseApiClient.Models.Authentication
{
    internal class TokenResponseModel
    {
        [JsonPropertyName("token_type")]
        public string TokenType { get; init; }

        [JsonPropertyName("access_token")]
        public string AccessToken { get; init; }
    }
}
