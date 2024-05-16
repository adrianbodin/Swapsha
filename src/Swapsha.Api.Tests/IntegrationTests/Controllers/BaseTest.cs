using System.Net.Http.Headers;
using Swapsha.Api.Features.Users.Models;
using Swapsha.Api.Tests.Fixtures;
using Swapsha.Api.Tests.IntegrationTests.Controllers.Users;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers;

public abstract class BaseTest : IAsyncLifetime
{
    protected readonly HttpClient client;
    private readonly Func<Task> _resetDatabase;

    protected BaseTest(ApiFactory factory)
    {
        client = factory.HttpClient;
        _resetDatabase = factory.ResetDatabaseAsync;
    }

    public virtual async Task InitializeAsync()
    {
        // Set the Authorization header to an empty string before each test
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "");
        await Task.CompletedTask;
    }

    protected async Task<GetAllUsersResponse> AuthenticateUser()
    {
        var validUser = await GetValidUser(client);
        await LoginUser(client, validUser);
        return validUser;
    }

    public Task DisposeAsync() => _resetDatabase();
}