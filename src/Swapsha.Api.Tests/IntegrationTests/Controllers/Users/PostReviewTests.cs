using System.Net;
using System.Net.Http.Json;
using Swapsha.Api.Models.Dtos;
using Swapsha.Api.Tests.Fixtures;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers.Users;

[Collection("TestCollection")]
public class PostReviewTests(ApiFactory factory) : BaseTest(factory)
{
    [Fact]
    public async Task OK_When_Review_AddedSuccessfully()
    {
        var postingUser = await GetValidUser(_client);
        var recievingUser = await GetValidUser(_client);

        var validReview = new PostReviewRequest(4, recievingUser.UserId);

        await AuthenticateUser(_client, postingUser);

        var response = await _client.PostAsJsonAsync($"/api/v1/users/{postingUser.UserId}/reviews", validReview);

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task BadRequest_When_Request_Body_Is_Invalid()
    {
        var user = await GetValidUser(_client);
        await AuthenticateUser(_client, user);
        var notValidRequest = new PostReviewRequest(0, Guid.NewGuid().ToString());

        var response = await _client.PostAsJsonAsync($"/api/v1/users/{user.UserId}/reviews", notValidRequest);

        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
    }
}