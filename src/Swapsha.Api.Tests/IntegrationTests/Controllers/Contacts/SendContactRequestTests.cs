using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Swapsha.Api.Tests.Fixtures;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers.Contacts;

[Collection("TestCollection")]
public class SendContactRequestTests(ApiFactory factory) : BaseTest(factory)
{
    [Fact]
    public async Task Unauthorized_When_Not_Logged_In()
    {
        var randomGuid = Guid.NewGuid().ToString();

        //had to user StringContent because i don't want to send anything in the body
        var response = await client.PostAsync($"api/v1/users/{randomGuid}/contact", new StringContent(""));

        Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
    }

    [Fact]
    public async Task BadRequest_When_Route_Id_Is_Not_Valid_GUID()
    {
        await AuthenticateUser();

        var notOkGuid = "tahodw-sitehadwy-wdyah";

        var response = await client.PostAsync($"api/v1/users/{notOkGuid}/contact", new StringContent(""));

        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
    }

    //todo this has a bug, if the user already has a contact with the user, it will return 400
    //todo check before what contacts the user has

    [Fact]
    public async Task Created_When_Valid_Request()
    {
        await AuthenticateUser();

        var validUser = await GetValidUser(client);

        var response = await client.PostAsync($"api/v1/users/{validUser.UserId}/contact", new StringContent(""));

        Assert.Equal(HttpStatusCode.Created, response.StatusCode);
    }
}