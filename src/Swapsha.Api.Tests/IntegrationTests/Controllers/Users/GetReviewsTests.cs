using System.Net;
using Swapsha.Api.Tests.Fixtures;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers.Users;

[Collection("TestCollection")]
public class GetReviewsTests(ApiFactory factory) : BaseTest(factory)
{
    [Fact]
    public async Task OK_When_Reviews_Found()
    {
        var validUser = await GetValidUser(_client);

        var response = await _client.GetAsync($"api/v1/users/{validUser.UserId}/reviews");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task NotFound_When_User_Has_No_Reviews()
    {
        var randomUserId = Guid.NewGuid().ToString();

        var response = await _client.GetAsync($"api/v1/users/{randomUserId}/reviews");

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }
}