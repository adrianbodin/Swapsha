using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Build.ObjectModelRemoting;

namespace Swapsha.Api.Features.Skills.Filters;

public class ValidSkillIdFilterAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        base.OnActionExecuting(context);

        var id = context.ActionArguments["id"];

        if (!((int)id >= 1))
        {
            context.ModelState.AddModelError("id", "has to be more than 0");
            var problemDetails = new ValidationProblemDetails(context.ModelState)
            {
                Status = 400
            };
            context.Result = new BadRequestObjectResult(problemDetails);
        }

    }
}