using HarryPotterApiService.Dto;

namespace HarryPotterApiService.Builders
{
    public class WandDtoBuilder
    {
        private WandDto wand = new WandDto();

        public WandDtoBuilder WithWood(string wood)
        {
            wand.Wood = wood;
            return this;
        }

        public WandDtoBuilder WithCore(string core)
        {
            wand.Core = core;
            return this;
        }

        public WandDtoBuilder WithLength(double? length)
        {
            wand.Length = length;
            return this;
        }

        public WandDto Build()
        {
            return wand;
        }
    }
}
