using Newtonsoft.Json;

namespace HarryPotterApiService.Dto
{
    public class WandDto
    {
        [JsonProperty("wood")]
        public string Wood { get; set; } = string.Empty;

        [JsonProperty("core")]
        public string Core { get; set; } = string.Empty;

        [JsonProperty("length")]
        public double? Length { get; set; }
    }
}