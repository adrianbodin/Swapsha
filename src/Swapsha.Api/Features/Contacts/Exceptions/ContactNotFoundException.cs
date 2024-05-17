using System.Net;
using Swapsha.Api.Shared.Exceptions;

namespace Swapsha.Api.Features.Contacts.Exceptions;

public class ContactNotFoundException : CustomException
{
    public ContactNotFoundException(string message) : base(message, (int)HttpStatusCode.NotFound)
    {
    }
}