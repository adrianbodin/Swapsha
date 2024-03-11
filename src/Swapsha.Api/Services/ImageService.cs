using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace Swapsha.Api.Services;

public class ImageService : IImageService
{
    private readonly BlobServiceClient _blobClient;

    public ImageService(BlobServiceClient blobClient)
    {
        _blobClient = blobClient;
    }

    public async Task<string> AddProfilePic(string userId, IFormFile image)
    {
        var containerClient = _blobClient.GetBlobContainerClient(userId);
        await containerClient.CreateIfNotExistsAsync(PublicAccessType.Blob);

        var blobName = "profilepic.jpg";
        var blobClient = containerClient.GetBlobClient(blobName);

        using var stream = image.OpenReadStream();
        await blobClient.UploadAsync(stream, overwrite: true);

        return blobClient.Uri.ToString();
    }
}