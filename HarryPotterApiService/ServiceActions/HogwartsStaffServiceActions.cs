using BaseApiClient;

using HarryPotterApiService.Dto;

using RestSharp;

namespace HarryPotterApiService.ServiceActions
{
    public class HogwartsStaffServiceActions : BaseServiceActions
    {
        public HogwartsStaffServiceActions(ApiClient client) : base(client)
        {
        }

        public RestResponse<StaffDto[]> GetAllHogwartsStaff()
        {
            RestRequest request = new RestRequest("characters", Method.Get);
            return this.apiClient.ExecuteGet<StaffDto[]>(request);
        }
    }
}
