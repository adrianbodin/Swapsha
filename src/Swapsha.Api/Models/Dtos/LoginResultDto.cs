namespace Swapsha.Api.Models.Dtos;

public record LoginResultDto(string TokenType, string AccessToken, int ExpiresIn, string RefreshToken);