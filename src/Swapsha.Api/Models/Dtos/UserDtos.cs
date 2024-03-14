namespace Swapsha.Api.Models.Dtos;

public record LoginDto(string Email, string Password);

public record LoginResultDto(string TokenType, string AccessToken, int ExpiresIn, string RefreshToken);

public record UserFirstNameDto(string FirstName);
