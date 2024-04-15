using System.Net;
using Swapsha.Api.Exceptions;

namespace Swapsha.Api.Features.Users.Exceptions;

public class DuplicateWantedSkillException : CustomException
{
    public DuplicateWantedSkillException(string message) : base(message, (int)HttpStatusCode.BadRequest)
    {
    }
}