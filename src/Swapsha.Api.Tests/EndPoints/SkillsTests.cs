using System.Net.Http.Json;
using Swapsha.Api.Models.Dtos;
using Swapsha.Api.Tests.Fixtures;

namespace Swapsha.Api.Tests.Tests;

public class SkillsTests: IClassFixture<DockerWebApplicationFactoryFixture>
{
    private readonly DockerWebApplicationFactoryFixture _factory;
    private readonly HttpClient _client;

    public SkillsTests(DockerWebApplicationFactoryFixture factory)
    {
        _factory = factory;
        _client = _factory.CreateClient();
    }

    [Fact]
    public async Task Hello()
    {
        var response = await _client.GetAsync("/api/v1/skills");
        var result = await response.Content.ReadFromJsonAsync<List<SkillDto>>();

        result[0].Name.Should().Be("Programmering");

        result.Should().BeOfType<List<SkillDto>>();
    }
}