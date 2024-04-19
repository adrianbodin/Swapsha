using System.Net;
using Swapsha.Api.Shared.Exceptions;

namespace Swapsha.Api.Features.Skills.Exceptions;

public class NoSkillsFoundException : CustomException
{
    public NoSkillsFoundException(string message) : base(message, (int)HttpStatusCode.NotFound)
    {
    }
}