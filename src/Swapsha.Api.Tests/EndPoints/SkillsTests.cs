using System.Net.Http.Json;
using Swapsha.Api.Models.Dtos;
using Swapsha.Api.Tests.Fixtures;

namespace Swapsha.Api.Tests.EndPoints;

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
    public async Task Hello()
    {
        var response = await _client.GetAsync("/api/v1/skills");
        var result = await response.Content.ReadFromJsonAsync<List<SkillDto>>();

        result[0].Name.Should().Be("Programmering");

        result.Should().BeOfType<List<SkillDto>>();
    }

    public Task InitializeAsync() => Task.CompletedTask;

    public Task DisposeAsync() => _resetDatabase();
}