using BaseApiClient;
using BaseApiClient.Extensions;

using HarryPotterApiService.Dto;

using RestSharp;

using System.Net;

namespace HarryPotterApiService.ServiceActions
{
    public class CharacterServiceActions : BaseServiceActions
    {
        public CharacterServiceActions(ApiClient client) : base(client)
        {
        }

        public RestResponse<CharacterDto[]> GetAllCharacters()
        {
            RestRequest request = new RestRequest("characters", Method.Get);
            return this.apiClient.GetRequest<CharacterDto[]>(request);
        }

        public RestResponse<CharacterDto> GetCharacter(Guid id)
        {
            RestRequest request = new RestRequest($"characters/{id}", Method.Get);
            return this.apiClient.GetRequest<CharacterDto>(request);
        }

        public HttpStatusCode AddNewCharacter(CharacterDto character)
        {
            RestRequest request = new RestRequest("characters", Method.Post).AddJsonBody(character);
            return this.apiClient.PostRequest<CharacterDto>(request).StatusCode;
        }
    }
}
