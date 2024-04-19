using System.Net.Http.Headers;
using System.Net.Http.Json;
using Swapsha.Api.Features.Users;
using Swapsha.Api.Features.Users.Models;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers.Users;

public static class UserUtils
{
    internal static PostNamesRequest ValidUserNamesDto()
    {
        return new PostNamesRequest
        {
            FirstName = "John",
            MiddleName = "Doe",
            LastName = "Smith"
        };
    }

    internal static PostNamesRequest InvalidUserNamesDto()
    {
        return new PostNamesRequest
        {
            FirstName = "Joe",
            MiddleName = "Hello",
            LastName = ""
        };
    }

    internal static PostFirstNameRequest ValidFirstNameDto()
    {
        return new PostFirstNameRequest
        {
            FirstName = "Adrian"
        };
    }

    internal static PostFirstNameRequest InvalidFirstNameDto()
    {
        return new PostFirstNameRequest
        {
            FirstName = ""
        };
    }

    internal static async Task AuthenticateUser(HttpClient client, GetAllUsersResponse validUser)
    {
        var loginResponse = await client.PostAsJsonAsync("/api/v1/identity/login", new LoginDto(validUser.Email, "Admin123!"));
        var loginResult = await loginResponse.Content.ReadFromJsonAsync<LoginResultDto>();
        var token = loginResult.AccessToken;
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
    }

    internal static async Task<GetAllUsersResponse> GetValidUser(HttpClient client)
    {
        var response = await client.GetAsync("/api/v1/users");
        var users = await response.Content.ReadFromJsonAsync<PaginatedResponse<GetAllUsersResponse>>();
        var random = new Random();
        return users.Data.OrderBy(u => random.Next()).First();
    }
}