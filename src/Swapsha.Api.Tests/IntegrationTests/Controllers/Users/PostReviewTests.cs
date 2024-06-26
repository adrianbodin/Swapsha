﻿using System.Net;
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
    [Fact]
    public async Task OK_When_Review_AddedSuccessfully()
    {
        var recievingUser = await GetValidUser(client);

        var validReview = new PostReviewRequest
        {
            Rating = 4,
            UserId = recievingUser.UserId
        };

        var validUser = await AuthenticateUser();

        var response = await client.PostAsJsonAsync($"/api/v1/users/{validUser.UserId}/reviews", validReview);

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task BadRequest_When_Request_Body_Is_Invalid()
    {
        var validUser = await AuthenticateUser();
        var notValidRequest = new PostReviewRequest
        {
            Rating = 0,
            UserId = Guid.NewGuid().ToString()
        };

        var response = await client.PostAsJsonAsync($"/api/v1/users/{validUser.UserId}/reviews", notValidRequest);

        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
    }

    [Fact]
    public async Task Unauthorized_When_Id_Of_Route_Is_Not_Valid_User_Id()
    {
        var invalidUserId = Guid.NewGuid().ToString();
        var validRequest = new PostReviewRequest
        {
            Rating = 4,
            UserId = invalidUserId
        };

        await AuthenticateUser();

        var response = await client.PostAsJsonAsync($"/api/v1/users/{invalidUserId}/reviews", validRequest);

        Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
    }

}