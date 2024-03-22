namespace Swapsha.Api.Shared.Services;

public interface IImageService
{
    public Task<string> AddProfilePic(string userId, IFormFile image);
}