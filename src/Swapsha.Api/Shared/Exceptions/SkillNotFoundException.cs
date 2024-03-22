using System.Net;

namespace Swapsha.Api.Exceptions;

public class SkillNotFoundException : CustomException
{
    public SkillNotFoundException(string message) : base(message, (int)HttpStatusCode.NotFound)
    {
    }
}