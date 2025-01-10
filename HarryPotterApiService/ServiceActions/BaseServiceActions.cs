using BaseApiClient;

namespace HarryPotterApiService.ServiceActions
{
    public class BaseServiceActions
    {
        protected ApiClient apiClient;

        public BaseServiceActions(ApiClient client)
        {
            this.apiClient = client;
        }
    }
}
