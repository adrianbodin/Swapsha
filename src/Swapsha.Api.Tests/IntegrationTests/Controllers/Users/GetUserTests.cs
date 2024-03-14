using System.Net;
using System.Net.Http.Json;
using Swapsha.Api.Controllers;
using Swapsha.Api.Data.Seed;
using Swapsha.Api.Tests.Fixtures;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers.Users;

[Collection("TestCollection")]
public class GetUserTests : BaseTest
{
    public GetUserTests(ApiFactory factory) : base(factory)
    {
    }

    [Fact]
    public async Task OK_When_Getting_User()
    {
        var validUser = UserSeed.SeedUsers().First();

        var response = await _client.GetAsync($"/api/v1/users/{validUser.Id}");
        var userResponse = await response.Content.ReadFromJsonAsync<GetUserResponse>();

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        userResponse?.UserId.Should().BeEquivalentTo(validUser.Id);
    }

    [Fact]
    public async Task NotFound_When_Id_Is_Not_Valid_UserId()
    {
        var randomGuid = new Guid().ToString();

        var response = await _client.GetAsync($"/api/v1/users/{randomGuid}");

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }
}