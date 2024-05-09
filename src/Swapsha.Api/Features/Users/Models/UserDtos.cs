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

public record GetAllUsersRequest
{
    public int? SkillId { get; init; }

    public string? SortBy { get; init; }

    [Range(1, int.MaxValue, ErrorMessage = "Page index must be greater than 0.")]
    public int PageIndex { get; init; } = 1;

    [Range(1, 100, ErrorMessage = "Page size must be between 1 and 100.")]
    public int PageSize { get; init; } = 10;
}

public record GetAllUsersResponse(
    string UserId,
    string? FullName,
    string? City,
    string? ProfilePictureUrl,
    int? TotalReviews,
    int? AverageRating,
    List<string> Skills);

public record GetUserSkillDto(int Id, string Name);

public record GetUserResponse(
    string UserId,
    string? FullName,
    string? City,
    string? ProfilePictureUrl,
    List<GetUserSkillDto>? Skills,
    List<GetUserSkillDto>? WantedSkills);

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
