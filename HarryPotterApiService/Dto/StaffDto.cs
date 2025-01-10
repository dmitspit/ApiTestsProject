using Newtonsoft.Json;

namespace HarryPotterApiService.Dto
{
    public class StaffDto
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("alternate_names")]
        public string[] AlternateNames { get; set; } = Array.Empty<string>();

        [JsonProperty("species")]
        public string Species { get; set; } = string.Empty;

        [JsonProperty("gender")]
        public string Gender { get; set; } = string.Empty;

        [JsonProperty("house")]
        public string House { get; set; } = string.Empty;

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; } = string.Empty;

        [JsonProperty("yearOfBirth")]
        public int? YearOfBirth { get; set; }

        [JsonProperty("wizard")]
        public bool Wizard { get; set; }

        [JsonProperty("ancestry")]
        public string Ancestry { get; set; } = string.Empty;

        [JsonProperty("eyeColour")]
        public string EyeColour { get; set; } = string.Empty;

        [JsonProperty("hairColour")]
        public string HairColour { get; set; } = string.Empty;

        [JsonProperty("wand")]
        public WandDto Wand { get; set; }

        [JsonProperty("patronus")]
        public string Patronus { get; set; } = string.Empty;

        [JsonProperty("hogwartsStudent")]
        public bool HogwartsStudent { get; set; }

        [JsonProperty("hogwartsStaff")]
        public bool HogwartsStaff { get; set; }

        [JsonProperty("actor")]
        public string Actor { get; set; } = string.Empty;

        [JsonProperty("alternate_actors")]
        public string[] AlternateActors { get; set; } = Array.Empty<string>();

        [JsonProperty("alive")]
        public bool Alive { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; } = string.Empty;
    }
}
