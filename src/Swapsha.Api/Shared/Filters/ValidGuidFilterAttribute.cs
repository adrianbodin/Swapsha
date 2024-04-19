using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
namespace Swapsha.Api.Shared.Filters;

public class ValidGuidFilterAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        base.OnActionExecuting(context);

        var id = context.ActionArguments["id"];

        if (!Guid.TryParse(id?.ToString(), out _))
        {
            context.ModelState.AddModelError("id", "Id is not a valid Guid");
            var problemDetails = new ValidationProblemDetails(context.ModelState)
            {
                Status = 400
            };
            context.Result = new BadRequestObjectResult(problemDetails);
        }
    }
}