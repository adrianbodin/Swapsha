﻿using System.Net;
using System.Net.Http.Json;
using Swapsha.Api.Data.Seed;
using Swapsha.Api.Tests.Fixtures;
using static Swapsha.Api.Tests.IntegrationTests.Controllers.Users.UserUtils;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers.Users;

[Collection("TestCollection")]
public class UpdateFirstNameTests(ApiFactory factory) : BaseTest(factory)
{
    [Fact]
    public async Task Unauthorized_When_Not_Authenticated()
    {
        var randomGuid = Guid.NewGuid().ToString();
        //Act
        var response = await client.PatchAsJsonAsync($"/api/v1/users/{randomGuid}/firstname", ValidFirstNameDto());

        //Assert
        Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
    }


    [Fact]
    public async Task OK_When_Authenticated()
    {
        // Arrange
        var validUser = await AuthenticateUser();

        //Act
        var response = await client.PatchAsJsonAsync($"/api/v1/users/{validUser.UserId}/firstname", ValidFirstNameDto());

        //Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task BadRequest_When_Invalid_Data()
    {
        // Arrange
        var validUser = await AuthenticateUser();

        //Act
        var response = await client.PatchAsJsonAsync($"/api/v1/users/{validUser.UserId}/firstname", InvalidFirstNameDto());

        //Assert
        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
    }

    [Fact]
    public async Task Unauthorized_When_RouteId_Does_Not_Match_UserId()
    {
        // Arrange
        var randomGuid = Guid.NewGuid().ToString();
        await AuthenticateUser();

        //Act
        var response = await client.PatchAsJsonAsync($"/api/v1/users/{randomGuid}/firstname", ValidFirstNameDto());

        //Assert
        Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
    }
}