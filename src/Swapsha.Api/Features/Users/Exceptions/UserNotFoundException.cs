using System.Net;
using Swapsha.Api.Shared.Exceptions;

namespace Swapsha.Api.Features.Users.Exceptions;

public class UserNotFoundException : CustomException
{
    public UserNotFoundException(string message) : base(message, (int)HttpStatusCode.NotFound)
    {
    }
}