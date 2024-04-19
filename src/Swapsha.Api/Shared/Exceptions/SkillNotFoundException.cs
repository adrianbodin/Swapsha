using System.Net;

namespace Swapsha.Api.Shared.Exceptions;

public class SkillNotFoundException : CustomException
{
    public SkillNotFoundException(string message) : base(message, (int)HttpStatusCode.NotFound)
    {
    }
}