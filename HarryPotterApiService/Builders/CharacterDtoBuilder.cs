using HarryPotterApiService.Dto;

namespace HarryPotterApiService.Builders
{
    public class CharacterDtoBuilder
    {
        private CharacterDto character = new CharacterDto();

        public CharacterDtoBuilder WithId(Guid id)
        {
            character.Id = id;
            return this;
        }

        public CharacterDtoBuilder WithName(string name)
        {
            character.Name = name;
            return this;
        }

        public CharacterDtoBuilder WithAlternateNames(string[] alternateNames)
        {
            character.AlternateNames = alternateNames;
            return this;
        }

        public CharacterDtoBuilder WithWand(WandDto wand)
        {
            character.Wand = wand;
            return this;
        }

        public CharacterDto Build()
        {
            return character;
        }
    }
}
