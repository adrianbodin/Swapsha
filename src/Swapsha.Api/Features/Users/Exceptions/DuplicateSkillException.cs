using System.Net;
using Swapsha.Api.Shared.Exceptions;

namespace Swapsha.Api.Features.Users.Exceptions;

public class DuplicateSkillException : CustomException
{
    public DuplicateSkillException(string message) : base(message, (int)HttpStatusCode.BadRequest)
    {
    }
}