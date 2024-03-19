namespace Swapsha.Api.Models.Dtos;

public record LoginDto(
    string Email,
    string Password);

public record LoginResultDto(
    string TokenType,
    string AccessToken,
    int ExpiresIn,
    string RefreshToken);

public record PaginatedResponse<T>(
    int PageIndex,
    int PageSize,
    int TotalRecords,
    List<T> Data);

public record GetAllUsersResponse(
    string UserId,
    string? Email,
    string? FirstName,
    string? LastName,
    string? ProfilePictureUrl,
    List<GetAllUsersSkills> Skills,
    List<GetAllUsersSkills> WantedSkills);

public record GetAllUsersSkills(
    string Name,
    string Description);

public record GetUserResponse(
    string UserId,
    string? Email,
    string? FirstName,
    string? LastName,
    string? ProfilePictureUrl);

public record PostNamesRequest(
    string FirstName,
    string MiddleName,
    string LastName);

public record GetNamesResponse(
    string FirstName,
    string MiddleName,
    string LastName);

public record PostFirstNameRequest(
    string FirstName);

public record GetProfilePicResponse(
    string UserId,
    string? ProfilePicUrl);

public record AddSkillToUserRequest(
    int SkillId);

public record AddWantedSkillToUserRequest(
    int SkillId);