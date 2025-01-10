using BaseApiClient;

using HarryPotterApiService.Dto;

using RestSharp;

namespace HarryPotterApiService.ServiceActions
{
    public class SpellServiceActions : BaseServiceActions
    {
        public SpellServiceActions(ApiClient client) : base(client)
        {
        }

        public RestResponse<SpellDto[]> GetAllSpells()
        {
            RestRequest request = new RestRequest("spells", Method.Get);
            return this.apiClient.ExecuteGet<SpellDto[]>(request);
        }
    }
}
