using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using Swapsha.Api.Features.Contacts.Models;
using Swapsha.Api.Features.Contacts.Services;
using Swapsha.Api.Features.Users.Filters;
using Swapsha.Api.Features.Users.Models;
using Swapsha.Api.Shared.Filters;
using Swashbuckle.AspNetCore.Annotations;

namespace Swapsha.Api.Features.Contacts;

[Route("api/v1")]
[ApiController]
public class ContactEndpoints : ControllerBase
{
    private readonly UserManager<CustomUser> _userManager;
    private readonly IContactService _contactService;

    public ContactEndpoints(UserManager<CustomUser> userManager, IContactService contactService)
    {
        _userManager = userManager;
        _contactService = contactService;
    }

    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Send a contact request to another user.",
        Description = @"Send a contact request to another user. 
                        The request will be pending until the other user accepts or declines it.",
        OperationId = "SendContactRequest",
        Tags = ["Users"]
    )]
    [SwaggerResponse(201, "Contact request sent successfully.", typeof(SendContactRequestResponse))]
    [SwaggerResponse(400, "Invalid user ID.")]
    [SwaggerResponse(401, "Unauthorized.")]
    #endregion
    [Authorize]
    [HttpPost("users/{id}/contact")]
    [TypeFilter(typeof(ValidGuidFilterAttribute))]
    public async Task<IActionResult> SendContactRequest(string id)
    {
        var user = await _userManager.GetUserAsync(User);

        var contactRequest = await _contactService.SendContactRequest(user.Id, id);

        var response = new SendContactRequestResponse(
            contactRequest.ContactRequestId,
            contactRequest.SenderId,
            contactRequest.ReceiverId,
            contactRequest.Status.ToString()
        );

        return CreatedAtAction(nameof(GetContactRequest), new {requestId = contactRequest.ContactRequestId}, response);
    }

    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Get a contact request by its ID.",
        Description = "Get a contact request by its ID. The request must be sent to the current user logged in.",
        OperationId = "GetContactRequest",
        Tags = ["Profile"]
    )]
    [SwaggerResponse(200, "Contact request found.", typeof(ContactRequest))]
    [SwaggerResponse(404, "Contact request not found.")]
    #endregion
    [Authorize]
    [HttpGet("profile/contact-requests/{requestId}")]
    [TypeFilter(typeof(ValidGuidFilterAttribute))]
    public async Task<ActionResult<ContactRequest>> GetContactRequest(string requestId)
    {
        var contactRequest = await _contactService.GetContactRequest(requestId);

        //todo change the return here
        return Ok(contactRequest);
    }

    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Get all pending sent contact requests.",
        Description = "Get all pending sent contact requests. The requests are sent by the current user logged in.",
        OperationId = "GetPendingSentRequests",
        Tags = ["Profile"])]
    [SwaggerResponse(200, "Sent requests found. This might be empty.", typeof(List<SentRequestDto>))]
    [SwaggerResponse(401, "Unauthorized.")]
    #endregion
    [Authorize]
    [HttpGet("profile/contact-requests/sent")]
    public async Task<ActionResult<List<SentRequestDto>>> GetPendingSentRequests()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var requests = await _contactService.GetAllSentRequests(userId);
        return Ok(requests);
    }

    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Get all pending received contact requests.",
        Description = "Get all pending received contact requests. The requests are sent to the current user logged in.",
        OperationId = "GetPendingReceivedRequests",
        Tags = ["Profile"])]
    [SwaggerResponse(200, "Received requests found. This might be empty.", typeof(List<ReceivedRequestDto>))]
    [SwaggerResponse(401, "Unauthorized.")]
    #endregion
    [Authorize]
    [HttpGet("profile/contact-requests/received")]
    public async Task<ActionResult<List<ReceivedRequestDto>>> GetPendingReceivedRequests()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var requests = await _contactService.GetAllReceivedRequests(userId);
        return Ok(requests);
    }

    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Approve a contact request.",
        Description = "Approve a contact request. The request must be sent to the current user logged in.",
        OperationId = "ApproveContactRequest",
        Tags = ["Profile"])]
    [SwaggerResponse(204, "Contact request approved.")]
    [SwaggerResponse(401, "Unauthorized.")]
    [SwaggerResponse(404, "Contact request not found.")]
    #endregion
    [Authorize]
    [HttpPut("profile/contact-requests/{id}/approve")]
    [TypeFilter(typeof(ValidGuidFilterAttribute))]
    public async Task<IActionResult> ApproveContactRequest(string id)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        await _contactService.ApproveContactRequest(userId, id);
        return NoContent();
    }

}
