using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Swapsha.Api.Features.Users.Models;

namespace Swapsha.Api.Features.Users.Filters;

public class ValidateUserFilterAttribute : IAsyncActionFilter
{
    private readonly UserManager<CustomUser> _userManager;

    public ValidateUserFilterAttribute(UserManager<CustomUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        var id = context.ActionArguments["id"] as string;
        var user = await _userManager.GetUserAsync(context.HttpContext.User);

        if (user == null || user.Id != id)
        {
            context.ModelState.AddModelError("", "You are not authorized to perform this action");
            var problemDetails = new ValidationProblemDetails(context.ModelState)
            {
                Status = 401
            };
            context.Result = new UnauthorizedObjectResult(problemDetails);
        }
        else
        {
            context.HttpContext.Items["User"] = user;
            await next();
        }
    }
}