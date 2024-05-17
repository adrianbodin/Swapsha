using System.Net;
using Swapsha.Api.Tests.Fixtures;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers.Contacts;

[Collection("TestCollection")]
public class GetPendingReceivedRequestsTests(ApiFactory factory) : BaseTest(factory)
{
    [Fact]
    public async Task Unauthorized_When_Not_Logged_In()
    {
        var response = await client.GetAsync("api/v1/profile/contact-requests/received");

        Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
    }

    [Fact]
    public async Task Ok_When_Logged_In()
    {
        await AuthenticateUser();

        var response = await client.GetAsync("api/v1/profile/contact-requests/received");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}