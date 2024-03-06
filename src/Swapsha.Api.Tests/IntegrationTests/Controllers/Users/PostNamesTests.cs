using System.Net;
using System.Net.Http.Json;
using Swapsha.Api.Data.Seed;
using Swapsha.Api.Tests.Fixtures;
using static Swapsha.Api.Tests.IntegrationTests.Controllers.Users.UserUtils;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers.Users;

[Collection("TestCollection")]
public class PostNamesTests : IAsyncLifetime
{
    private readonly HttpClient _client;
    private readonly Func<Task> _resetDatabase;

    public PostNamesTests(ApiFactory factory)
    {
        _client = factory.HttpClient;
        _resetDatabase = factory.ResetDatabaseAsync;
    }

    [Fact]
    public async Task ShouldGive401_WhenNotAuthenticated()
    {
        //Act
        var response = await _client.PostAsJsonAsync("/api/v1/users/1/names", ValidAddUserNamesDto());

        //Assert
        Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
    }


    [Fact]
    public async Task ShouldGive200_WhenAuthenticated()
    {
        // Arrange
        var validUser = UserSeed.SeedUsers().First();
        await AuthenticateUser(_client, validUser);

        //Act
        var response = await _client.PostAsJsonAsync($"/api/v1/users/{validUser.Id}/names", ValidAddUserNamesDto());

        //Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task ShouldGive400_WhenInvalidData()
    {
        // Arrange
        var validUser = UserSeed.SeedUsers().First();
        await AuthenticateUser(_client, validUser);

        //Act
        var response = await _client.PostAsJsonAsync($"/api/v1/users/{validUser.Id}/names", InvalidAddUserNamesDto());

        //Assert
        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
    }

    [Fact]
    public async Task ShouldGive401_WhenRouteIdDoesNotMatchUserId()
    {
        // Arrange
        var validUser = UserSeed.SeedUsers().First();
        await UserUtils.AuthenticateUser(_client, validUser);

        //Act
        var response = await _client.PostAsJsonAsync($"/api/v1/users/{validUser.Id + 1}/names", ValidAddUserNamesDto());

        //Assert
        Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
    }

    public Task InitializeAsync() => Task.CompletedTask;

    public Task DisposeAsync() => _resetDatabase();
}