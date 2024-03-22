using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swapsha.Api.Features.Reviews.Models;
using Swapsha.Api.Features.Users;
using Swapsha.Api.Features.Users.Models;
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

        var validReview = new PostReviewRequest
        {
            Rating = 4,
            UserId = recievingUser.UserId
        };

        await AuthenticateUser(_client, _user);

        var response = await _client.PostAsJsonAsync($"/api/v1/users/{_user.UserId}/reviews", validReview);

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task BadRequest_When_Request_Body_Is_Invalid()
    {
        await AuthenticateUser(_client, _user);
        var notValidRequest = new PostReviewRequest
        {
            Rating = 0,
            UserId = Guid.NewGuid().ToString()
        };

        var response = await _client.PostAsJsonAsync($"/api/v1/users/{_user.UserId}/reviews", notValidRequest);

        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
    }

    [Fact]
    public async Task NotFound_When_Id_Of_Route_Is_Not_Valid_User_Id()
    {
        var invalidUserId = Guid.NewGuid().ToString();
        var validRequest = new PostReviewRequest
        {
            Rating = 4,
            UserId = invalidUserId
        };

        await AuthenticateUser(_client, _user);

        var response = await _client.PostAsJsonAsync($"/api/v1/users/{invalidUserId}/reviews", validRequest);

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }

}