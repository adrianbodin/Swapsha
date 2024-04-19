using System.Diagnostics;
using System.Net;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Swapsha.Api.Shared.Exceptions;

public class ExceptionToProblemDetailsHandler : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        var statusCode = exception is CustomException customException
            ? customException.StatusCode
            : (int)HttpStatusCode.InternalServerError;

        httpContext.Response.StatusCode = statusCode;
        var traceId = Activity.Current?.Id ?? httpContext?.TraceIdentifier;
        var instance = httpContext.Request?.Path;
        httpContext.Response.ContentType = "application/problem+json";

        await httpContext.Response.WriteAsJsonAsync(new ProblemDetails
        {
            Title = "An error occurred",
            Detail = exception.Message,
            Type = exception.GetType().Name,
            Status = statusCode,
            Extensions =
            {
                { "trace-id", traceId },
                { "instance", instance?.Value }
            }
        }, cancellationToken: cancellationToken);

        return true;
    }
}