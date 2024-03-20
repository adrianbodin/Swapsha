using System.Net;
using System.Net.Http.Json;
using Swapsha.Api.Models.Dtos;
using Swapsha.Api.Tests.Fixtures;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers.Users;

[Collection("TestCollection")]
public class PostReviewTests(ApiFactory factory) : BaseTest(factory)
{
    private GetAllUsersResponse _user;

    public override async Task InitializeAsync()
    {
        await base.InitializeAsync();
        _user = await GetValidUser(_client);
    }

    [Fact]
    public async Task OK_When_Review_AddedSuccessfully()
    {
        var recievingUser = await GetValidUser(_client);

        var validReview = new PostReviewRequest(4, recievingUser.UserId);

        await AuthenticateUser(_client, _user);

        var response = await _client.PostAsJsonAsync($"/api/v1/users/{_user.UserId}/reviews", validReview);

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task BadRequest_When_Request_Body_Is_Invalid()
    {
        await AuthenticateUser(_client, _user);
        var notValidRequest = new PostReviewRequest(0, Guid.NewGuid().ToString());

        var response = await _client.PostAsJsonAsync($"/api/v1/users/{_user.UserId}/reviews", notValidRequest);

        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
    }

    [Fact]
    public async Task NotFound_When_Id_Of_Route_Is_Not_Valid_User_Id()
    {
        var invalidUserId = Guid.NewGuid().ToString();
        var validRequest = new PostReviewRequest(4, invalidUserId);

        await AuthenticateUser(_client, _user);

        var response = await _client.PostAsJsonAsync($"/api/v1/users/{invalidUserId}/reviews", validRequest);

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }

}