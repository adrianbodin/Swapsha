using System.Net.Http.Headers;
using System.Net.Http.Json;
using Swapsha.Api.Models;
using Swapsha.Api.Models.Dtos;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers.Users;

public static class UserUtils
{
    internal static PostNamesRequest ValidUserNamesDto()
    {
        return new PostNamesRequest("John", "Doe", "Smith");
    }

    internal static PostNamesRequest InvalidUserNamesDto()
    {
        return new PostNamesRequest("John", "Doe", "");
    }

    internal static PostFirstNameRequest ValidFirstNameDto()
    {
        return new PostFirstNameRequest("Adrian");
    }

    internal static PostFirstNameRequest InvalidFirstNameDto()
    {
        return new PostFirstNameRequest("");
    }

    internal static async Task AuthenticateUser(HttpClient client, CustomUser validUser)
    {
        var loginResponse = await client.PostAsJsonAsync("/api/v1/identity/login", new LoginDto(validUser.Email, "Admin123!"));
        var loginResult = await loginResponse.Content.ReadFromJsonAsync<LoginResultDto>();
        var token = loginResult.AccessToken;
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
    }
}