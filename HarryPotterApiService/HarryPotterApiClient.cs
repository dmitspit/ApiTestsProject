using BaseApiClient;

using HarryPotterApiService.Configurations;
using HarryPotterApiService.ServiceActions;

using Microsoft.Extensions.Options;

namespace HarryPotterApiService
{
    public class HarryPotterApiClient : BaseApiService
    {
        public CharacterServiceActions CharactersActions => new CharacterServiceActions(this.apiClient);

        public SpellServiceActions SpellActions => new SpellServiceActions(this.apiClient);

        public HogwartsStaffServiceActions HogwartsStaffActions => new HogwartsStaffServiceActions(this.apiClient);

        public HarryPotterApiClient(IOptionsMonitor<HarryPotterServiceSettings> serviceSettings) : base(serviceSettings)
        {
        }
    }
}