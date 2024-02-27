using Microsoft.OpenApi.Models;

namespace Swapsha.Api.EndPointDetails;

public static class HellosMetaData
{
    public static Func<OpenApiOperation, OpenApiOperation> GetAllHellos => operation =>
    {
        operation.Summary = "Hello";
        operation.Description = "This is a hello world endpoint";
        return operation;
    };

    public static Func<OpenApiOperation, OpenApiOperation> GetHello => operation =>
    {
        operation.Summary = "Hello";
        operation.Description = "This is a hello world endpoint";
        return operation;
    };
}