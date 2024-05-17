using System.Net;
using Swapsha.Api.Shared.Exceptions;

namespace Swapsha.Api.Features.Contacts.Exceptions;

public class ContactRequestNotFoundException : CustomException
{
    public ContactRequestNotFoundException(string message) : base(message, (int)HttpStatusCode.NotFound)
    {
    }
}