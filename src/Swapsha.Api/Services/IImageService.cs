using Azure.Storage.Blobs.Models;

namespace Swapsha.Api.Services;

public interface IImageService
{
    public Task<string> AddProfilePic(string userId, IFormFile image);
}