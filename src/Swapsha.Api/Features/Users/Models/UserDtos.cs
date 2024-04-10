using System.ComponentModel.DataAnnotations;

namespace Swapsha.Api.Features.Users.Models;

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
    string? FullName,
    string? ProfilePictureUrl,
    int? TotalReviews,
    int? AverageRating,
    List<string> Skills);

public record GetUserResponse(
    string UserId,
    string? Email,
    string? FirstName,
    string? LastName,
    string? ProfilePictureUrl);

public record PostNamesRequest
{
    [Required(ErrorMessage = "First name is required.")]
    [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
    public string FirstName { get; init; }

    [StringLength(50, ErrorMessage = "Middle name cannot be longer than 50 characters.")]
    public string MiddleName { get; init; }

    [Required(ErrorMessage = "Last name is required.")]
    [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters.")]
    public string LastName { get; init; }
}

public record GetNamesResponse(
    string FirstName,
    string MiddleName,
    string LastName);

public record PostFirstNameRequest
{
    [Required(ErrorMessage = "First name is required.")]
    [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
    public string FirstName { get; init; }
}

public record GetProfilePicResponse(
    string UserId,
    string? ProfilePicUrl);

public record AddSkillToUserRequest(
    int SkillId);

public record AddWantedSkillToUserRequest(
    int SkillId);