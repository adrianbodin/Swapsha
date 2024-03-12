using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Mvc;

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
        // Check file size
        const int maxFileSize = 5 * 1024 * 1024; // 5 MB
        if (image.Length > maxFileSize)
        {
            throw new Exception("File size exceeded the limit of 5MB");
        }

        var containerClient = _blobClient.GetBlobContainerClient(userId);
        await containerClient.CreateIfNotExistsAsync(PublicAccessType.Blob);

        // Get file extension
        var extension = Path.GetExtension(image.FileName);

        var blobName = $"profilepic{extension}";
        var blobClient = containerClient.GetBlobClient(blobName);

        await using var stream = image.OpenReadStream();
        try
        {
            var uploadOptions = new BlobUploadOptions
            {
                HttpHeaders = new BlobHttpHeaders
                {
                    ContentType = image.ContentType
                }
            };

            await blobClient.UploadAsync(stream, uploadOptions);
        }
        catch (Exception ex)
        {
            // Log the exception or handle it as needed
            throw new Exception("An error occurred while uploading the file", ex);
        }


        return blobClient.Uri.ToString();
    }
}