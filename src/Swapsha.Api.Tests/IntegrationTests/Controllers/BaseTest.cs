using Swapsha.Api.Tests.Fixtures;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers;

public abstract class BaseTest : IAsyncLifetime
{
    protected readonly HttpClient _client;
    protected readonly Func<Task> _resetDatabase;

    protected BaseTest(ApiFactory factory)
    {
        _client = factory.HttpClient;
        _resetDatabase = factory.ResetDatabaseAsync;
    }

    public Task InitializeAsync() => Task.CompletedTask;

    public Task DisposeAsync() => _resetDatabase();
}