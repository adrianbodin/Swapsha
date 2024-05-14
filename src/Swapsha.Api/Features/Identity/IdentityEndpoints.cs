using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Swapsha.Api.Features.Identity;

[Route("api/v1/identity")]
[ApiController]
public class IdentityEndpoints : ControllerBase
{

    //QUESTION maybe add some kind of delete if they use tokens in the headers
    //TODO make this be in the same place as the other identity endpoints in swagger
    [HttpPost("logout")]
    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Logs out the user from the application",
        Description = @"This endpoint logs out the user, it remove the 
                        httponly cookie from the client",
        OperationId = "Logout")]
    [SwaggerResponse(200, "If the cookie was deleted")]
    #endregion
    public async Task<IActionResult> Logout()
    {
        Response.Cookies.Delete(".AspNetCore.Identity.Application");
        return Ok();
    }

}