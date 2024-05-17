using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swapsha.Api.Features.Reviews.Models;
using Swapsha.Api.Features.Reviews.Services;
using Swapsha.Api.Features.Users.Filters;
using Swapsha.Api.Shared.Filters;
using Swashbuckle.AspNetCore.Annotations;

namespace Swapsha.Api.Features.Reviews;

[Route("api/v1/users")]
[ApiController]
public class ReviewEndpoints : ControllerBase
{
    private readonly IReviewService _reviewService;

    public ReviewEndpoints(IReviewService reviewService)
    {
        _reviewService = reviewService;
    }

    [HttpGet("{id}/reviews")]
    [TypeFilter(typeof(ValidGuidFilterAttribute))]
    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Gets all the reviews for a specific user",
        Description = @"This endpoint gets all the reviews that other users have
                        written for this user",
        OperationId = "GetReviews",
        Tags = ["Users"])]
    [SwaggerResponse(404, "There was no reviews for this user")]
    [SwaggerResponse(200, "If the request was successful")]
    #endregion
    public async Task<ActionResult<GetReviewsResponse>> GetReviews(string id)
    {
        var response = await _reviewService.GetReviewsByUserId(id);
        return Ok(response);
    }

    [Authorize]
    [HttpPost("{id}/reviews")]
    [TypeFilter(typeof(ValidGuidFilterAttribute))]
    [TypeFilter(typeof(ValidateUserFilterAttribute))]
    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Posts a new review",
        Description = @"Posts a new review, the id in the route should be the id
                        of the user that is submitting the review, and the userid
                        in the request body should be the id of the user to post to",
        OperationId = "PostReview",
        Tags = ["Users"])]
    [SwaggerResponse(400, "If the validation of the request body was not valid")]
    [SwaggerResponse(404, "If the id in the route was not a valid user id")]
    [SwaggerResponse(401, "If the route id is not the same as the id of the user hitting the endpoint")]
    [SwaggerResponse(200, "If the post request was successful")]
    #endregion
    public async Task<IActionResult> PostReview(string id, PostReviewRequest request)
    {
        await _reviewService.PostReview(id, request);
        return Ok();
    }
}