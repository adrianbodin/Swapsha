using System.Net;
using Swapsha.Api.Data.Seed;
using Swapsha.Api.Tests.Fixtures;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers.Users;

[Collection("TestCollection")]
public class GetNamesTests : IAsyncLifetime
{
    private readonly HttpClient _client;
    private readonly Func<Task> _resetDatabase;

    public GetNamesTests(ApiFactory factory)
    {
        _client = factory.HttpClient;
        _resetDatabase = factory.ResetDatabaseAsync;
    }

    [Fact]
    public async Task OK_When_Getting_Names()
    {
        // Arrange
        var validUser = UserSeed.SeedUsers().First();

        // Act
        var response = await _client.GetAsync($"/api/v1/users/{validUser.Id}/names");

        // Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task NotFound_When_RouteId_Is_Not_UserId()
    {
        var response = await _client.GetAsync($"/api/v1/users/546489/names");

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }

    public Task InitializeAsync() => Task.CompletedTask;

    public Task DisposeAsync() => _resetDatabase();
}