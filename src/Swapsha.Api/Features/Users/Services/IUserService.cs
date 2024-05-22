using Swapsha.Api.Features.Users.Models;

namespace Swapsha.Api.Features.Users.Services;

public interface IUserService
{
    Task<PaginatedResponse<GetAllUsersResponse>> GetAllUsers(GetAllUsersRequest request, string? loggedInUserId);

    Task<GetUserResponse> GetUserById(string id);

    Task<GetNamesResponse> GetNamesById(string id);

    Task<string> GetFirstNameById(string id);

    Task<GetProfilePicResponse> GetProfilePicById(string id);

    Task AddSkillToUser(string id, int skillId);

    Task AddWantedSkillToUser(string id, int skillId);

    Task<GetProfileResponse> GetProfile(CustomUser user);
}