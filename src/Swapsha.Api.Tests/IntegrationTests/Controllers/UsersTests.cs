using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Swapsha.Api.Data.Seed;
using Swapsha.Api.Models;
using Swapsha.Api.Models.Dtos;
using Swapsha.Api.Tests.Fixtures;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers;

[Collection("TestCollection")]
public class UsersTests : IAsyncLifetime
{
    private readonly HttpClient _client;
    private readonly Func<Task> _resetDatabase;

    public UsersTests(ApiFactory factory)
    {
        _client = factory.HttpClient;
        _resetDatabase = factory.ResetDatabaseAsync;
    }

    [Fact]
    public async Task AddUserNames_ShouldGive401_WhenNotAuthenticated()
    {
        //Act
        var response = await _client.PostAsJsonAsync("/api/v1/users/1/names", ValidAddUserNamesDto());

        //Assert
        Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
    }


    [Fact]
    public async Task AddUserNames_ShouldGive200_WhenAuthenticated()
    {
        // Arrange
        var validUser = UserSeed.SeedUsers().First();
        await AuthenticateUser(validUser);

        //Act
        var response = await _client.PostAsJsonAsync($"/api/v1/users/{validUser.Id}/names", ValidAddUserNamesDto());

        //Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task AddUserNames_ShouldGive400_WhenInvalidData()
    {
        // Arrange
        var validUser = UserSeed.SeedUsers().First();
        await AuthenticateUser(validUser);

        //Act
        var response = await _client.PostAsJsonAsync($"/api/v1/users/{validUser.Id}/names", InvalidAddUserNamesDto());

        //Assert
        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
    }

    [Fact]
    public async Task AddUserNames_ShouldGive401_WhenRouteIdDoesNotMatchUserId()
    {
        // Arrange
        var validUser = UserSeed.SeedUsers().First();
        await AuthenticateUser(validUser);

        //Act
        var response = await _client.PostAsJsonAsync($"/api/v1/users/{validUser.Id + 1}/names", ValidAddUserNamesDto());

        //Assert
        Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
    }



    #region Private Methods

    private static AddUserNamesDto ValidAddUserNamesDto()
    {
        return new AddUserNamesDto("John", "Doe", "Smith");
    }

    private static AddUserNamesDto InvalidAddUserNamesDto()
    {
        return new AddUserNamesDto("John", "Doe", "");
    }

    private async Task AuthenticateUser(CustomUser validUser)
    {
        var loginResponse = await _client.PostAsJsonAsync("/api/v1/identity/login", new LoginDto(validUser.Email, "Admin123!"));
        var loginResult = await loginResponse.Content.ReadFromJsonAsync<LoginResultDto>();
        var token = loginResult.AccessToken;
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
    }

    #endregion

    public Task InitializeAsync() => Task.CompletedTask;

    public Task DisposeAsync() => _resetDatabase();
}