using System.Net;
using Swapsha.Api.Tests.Fixtures;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers;

[Collection("TestCollection")]
public class SubSkillsTests : IAsyncLifetime
{
    private readonly HttpClient _client;
    private readonly Func<Task> _resetDatabase;

    public SubSkillsTests(ApiFactory factory)
    {
        _client = factory.HttpClient;
        _resetDatabase = factory.ResetDatabaseAsync;
    }

    [Fact]
    public async Task ShouldGet200_WhenGettingAllSubSkills()
    {
        var response = await _client.GetAsync("/api/v1/subskills");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task ShouldGet400_WhenGettingSubSkillByIdWithNegativeId()
    {
        var response = await _client.GetAsync("/api/v1/subskills/-1");

        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
    }

    [Fact]
    public async Task ShouldGet200_WhenGettingSubSkillById()
    {
        var response = await _client.GetAsync("/api/v1/skills/2");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    public Task InitializeAsync() => Task.CompletedTask;

    public Task DisposeAsync() => _resetDatabase();
}