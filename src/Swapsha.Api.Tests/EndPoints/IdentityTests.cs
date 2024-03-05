using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Swapsha.Api.Models.Dtos;
using Swapsha.Api.Tests.Fixtures;

namespace Swapsha.Api.Tests.EndPoints;

[Collection("TestCollection")]
public class IdentityTests : IAsyncLifetime
{
    private readonly HttpClient _client;
    private readonly Func<Task> _resetDatabase;

    public IdentityTests(ApiFactory factory)
    {
        _client = factory.HttpClient;
        _resetDatabase = factory.ResetDatabaseAsync;
    }

    [Fact]
    public async Task AddUserNames_ShouldGive401_WhenNotAuthenticated()
    {
        var response = await _client.PostAsJsonAsync("/api/v1/identity/usernames", new AddUserNamesDto("John", "Doe", "Smith"));

        Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
    }

    [Fact]
    public async Task AddUserNames_ShouldGive200_WhenAuthenticated()
    {
        // Authenticate the user and get the token
        var loginResponse = await _client.PostAsJsonAsync("/api/v1/identity/login", new LoginDto("test@example.com", "Admin123!"));
        var loginResult = await loginResponse.Content.ReadFromJsonAsync<LoginResultDto>();
        var token = loginResult.AccessToken;

        // Add the token to the Authorization header
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        // Make a request to the AddUserNames endpoint
        var response = await _client.PostAsJsonAsync("/api/v1/identity/usernames", new AddUserNamesDto("John", "Doe", "Smith"));

        // Assert that the status code is 200
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    public Task InitializeAsync() => Task.CompletedTask;

    public Task DisposeAsync() => _resetDatabase();
}