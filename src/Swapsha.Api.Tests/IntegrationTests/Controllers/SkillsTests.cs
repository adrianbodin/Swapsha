using System.Net;
using Swapsha.Api.Tests.Fixtures;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers;

[Collection("TestCollection")]
public class SkillsTests : IAsyncLifetime
{
    private readonly HttpClient _client;
    private readonly Func<Task> _resetDatabase;

    public SkillsTests(ApiFactory factory)
    {
        _client = factory.HttpClient;
        _resetDatabase = factory.ResetDatabaseAsync;
    }

    [Fact]
    public async Task ShouldGet200_WhenGettingAllSkills()
    {
        var response = await _client.GetAsync("/api/v1/skills");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task ShouldGet400_WhenGettingSkillByIdWithNegativeId()
    {
        var response = await _client.GetAsync("/api/v1/skills/-1");

        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
    }

    [Fact]
    public async Task ShouldGet200_WhenGettingSkillById()
    {
        var response = await _client.GetAsync("/api/v1/skills/2");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    public Task InitializeAsync() => Task.CompletedTask;

    public Task DisposeAsync() => _resetDatabase();
}