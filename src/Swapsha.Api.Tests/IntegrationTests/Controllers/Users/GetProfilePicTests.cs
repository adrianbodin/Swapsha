﻿using System.Net;
using System.Net.Http.Json;
using Swapsha.Api.Data.Seed;
using Swapsha.Api.Models.Dtos;
using Swapsha.Api.Tests.Fixtures;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers.Users;

[Collection("TestCollection")]
public class GetProfilePicTests(ApiFactory factory) : BaseTest(factory)
{
    [Fact]
    public async Task OK_When_Valid_Id_Of_User()
    {
        var validUser = UserSeed.SeedUsers().First();

        var response = await _client.GetAsync($"/api/v1/users/{validUser.Id}/profilepic");
        var content = await response.Content.ReadFromJsonAsync<GetProfilePicResponse>();

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        validUser.ProfilePictureUrl.Should().BeEquivalentTo(content?.ProfilePicUrl);
    }

    [Fact]
    public async Task NotFound_When_Id_Is_Not_Valid()
    {
        var notValidId = 556;

        var response = await _client.GetAsync($"/api/v1/users/{notValidId}/profilepic");

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }

}