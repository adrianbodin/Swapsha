using System.Net;
using Swapsha.Api.Data.Seed;
using Swapsha.Api.Tests.Fixtures;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers.Users;

[Collection("TestCollection")]
public class GetFirstNameTests(ApiFactory factory) : BaseTest(factory)
{
    [Fact]
    public async Task OK_When_Getting_FirstName()
    {
        // Arrange
        var validUser = await GetValidUser(_client);

        // Act
        var response = await _client.GetAsync($"/api/v1/users/{validUser.UserId}/firstname");

        // Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task BadRequest_When_RouteId_Is_Not_Valid_Guid()
    {
        var response = await _client.GetAsync($"/api/v1/users/546489/firstname");

        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
    }
}