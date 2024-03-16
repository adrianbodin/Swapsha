using System.Net;
using System.Net.Http.Json;
using Swapsha.Api.Data.Seed;
using Swapsha.Api.Tests.Fixtures;
using static Swapsha.Api.Tests.IntegrationTests.Controllers.Users.UserUtils;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers.Users;

[Collection("TestCollection")]
public class PostFirstNameTests(ApiFactory factory) : BaseTest(factory)
{
    [Fact]
    public async Task Unauthorized_When_Not_Authenticated()
    {
        //Act
        var response = await _client.PostAsJsonAsync("/api/v1/users/1/firstname", ValidFirstNameDto());

        //Assert
        Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
    }


    [Fact]
    public async Task OK_When_Authenticated()
    {
        // Arrange
        var validUser = UserSeed.SeedUsers().First();
        await AuthenticateUser(_client, validUser);

        //Act
        var response = await _client.PostAsJsonAsync($"/api/v1/users/{validUser.Id}/firstname", ValidFirstNameDto());

        //Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task BadRequest_When_Invalid_Data()
    {
        // Arrange
        var validUser = UserSeed.SeedUsers().First();
        await AuthenticateUser(_client, validUser);

        //Act
        var response = await _client.PostAsJsonAsync($"/api/v1/users/{validUser.Id}/firstname", InvalidFirstNameDto());

        //Assert
        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
    }

    [Fact]
    public async Task Unauthorized_When_RouteId_Does_Not_Match_UserId()
    {
        // Arrange
        var validUser = UserSeed.SeedUsers().First();
        await AuthenticateUser(_client, validUser);

        //Act
        var response = await _client.PostAsJsonAsync($"/api/v1/users/{validUser.Id + 1}/firstname", ValidFirstNameDto());

        //Assert
        Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
    }
}