using System.Net;
using System.Net.Http.Json;
using Swapsha.Api.Features.Skills.Models;
using Swapsha.Api.Features.Users.Models;
using Swapsha.Api.Tests.Fixtures;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers.Users;

[Collection("TestCollection")]
public class AddSkillToUserTests(ApiFactory factory) : BaseTest(factory)
{
    [Fact]
    public async Task BadRequest_When_Non_Valid_Id_Route()
    {
        var validUser = await GetValidUser(_client);
        await AuthenticateUser(_client, validUser);

        var response = await _client.PostAsJsonAsync($"api/v1/users/{445484}/skills", 1);

        Assert.Equal(HttpStatusCode.BadRequest,response.StatusCode);
    }

    [Fact]
    public async Task Unauthorized_When_No_Bearer_Header()
    {
        var randomGuid = Guid.NewGuid().ToString();

        var response = await _client.PostAsJsonAsync($"api/v1/users/{randomGuid}/skills", 1);

        Assert.Equal(HttpStatusCode.Unauthorized,response.StatusCode);
    }

    [Fact]
    public async Task Unauthorized_When_RouteId_Dont_Match_Logged_In_User()
    {
        var validUser = await GetValidUser(_client);
        await AuthenticateUser(_client, validUser);
        var randomGuid = Guid.NewGuid().ToString();

        var response = await _client.PostAsJsonAsync($"api/v1/users/{randomGuid}/skills", 1);

        Assert.Equal(HttpStatusCode.Unauthorized,response.StatusCode);
    }

    [Fact]
    public async Task BadRequest_When_User_Already_Has_Skill()
    {
        var validUser = await GetValidUser(_client);
        await AuthenticateUser(_client, validUser);

        var userResponse = await _client.GetAsync($"api/v1/users/{validUser.UserId}");

        var user = await userResponse.Content.ReadFromJsonAsync<GetUserResponse>();

        var response = await _client.PostAsJsonAsync($"api/v1/users/{validUser.UserId}/skills", user.Skills[0]);

        Assert.Equal(HttpStatusCode.BadRequest,response.StatusCode);
    }

    [Fact]
    public async Task NotFound_When_SkillId_Is_Not_A_Valid_Skill()
    {
        var validUser = await GetValidUser(_client);
        await AuthenticateUser(_client, validUser);

        var response = await _client.PostAsJsonAsync($"api/v1/users/{validUser.UserId}/skills", 54898);

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }

    [Fact]
    public async Task OK_When_Successfully_Added_Skill()
    {
        var validUser = await GetValidUser(_client);
        await AuthenticateUser(_client, validUser);

        // Fetch all skills
        var allSkillsResponse = await _client.GetAsync("api/v1/skills");
        var allSkills = await allSkillsResponse.Content.ReadFromJsonAsync<List<SkillDto>>();

        var userResponse = await _client.GetAsync($"api/v1/users/{validUser.UserId}");
        var user = await userResponse.Content.ReadFromJsonAsync<GetUserResponse>();

        // Find a skill that the user does not have
        var newSkill = allSkills.FirstOrDefault(skill => !user.Skills.Any(userSkill => userSkill.Id == skill.Id));

        var response = await _client.PostAsJsonAsync($"api/v1/users/{validUser.UserId}/skills", newSkill.Id);

        Assert.Equal(HttpStatusCode.OK,response.StatusCode);
    }

}