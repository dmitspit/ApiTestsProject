using FluentAssertions;

using HarryPotterApiService;
using HarryPotterApiService.Builders;
using HarryPotterApiService.Dto;

using Microsoft.Extensions.DependencyInjection;

using RestSharp;

using System.Net;

namespace HarryPotterApiTests.Test
{
    [TestFixture]
    public class CharacterTests : BaseTest
    {
        [Test]
        public void ResponseShouldNotBeNullAndStatusCodeIsOk()
        {
            HarryPotterApiClient service = serviceProvider.GetRequiredService<HarryPotterApiClient>();

            RestResponse<CharacterDto[]> charactersResponse = service.CharactersActions.GetAllCharacters();

            charactersResponse.StatusCode.Should().Be(HttpStatusCode.OK,
                "Status code should be 200(OK) after request to get all characters");
            charactersResponse.Data.Should().NotBeNull("All characters should be in the response");
        }

        [Test]
        public void NewCharacterShouldBeAdded() 
        {
            HarryPotterApiClient service = serviceProvider.GetRequiredService<HarryPotterApiClient>();

            CharacterDto character = new CharacterDtoBuilder()
            .WithId(Guid.NewGuid())
            .WithName("Harry Potter")
            .WithWand(new WandDtoBuilder().WithWood("Holly").WithCore("Phoenix Feather").WithLength(11.0).Build())
            .Build();

            HttpStatusCode statusCode = service.CharactersActions.AddNewCharacter(character);

            statusCode.Should().Be(HttpStatusCode.Created,
                "Status code should be 201(Created) after creating new character");
        }
    }
}