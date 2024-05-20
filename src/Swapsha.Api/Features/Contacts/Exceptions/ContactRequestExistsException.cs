using System.Net;
using Swapsha.Api.Shared.Exceptions;

namespace Swapsha.Api.Features.Contacts.Exceptions;

public class ContactRequestExistsException : CustomException
{
    public ContactRequestExistsException(string message) : base(message, (int)HttpStatusCode.BadRequest)
    {
    }
}