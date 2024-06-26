﻿using System.Net;
using Swapsha.Api.Tests.Fixtures;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers.Users;

[Collection("TestCollection")]
public class GetAllUsersTests(ApiFactory factory) : BaseTest(factory)
{
    [Fact]
    public async Task OK_When_Users_In_The_Db()
    {
        var response = await client.GetAsync($"/api/v1/users");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}