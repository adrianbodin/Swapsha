using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swapsha.Api.Data;
using Swapsha.Api.Features.Reviews.Models;
using Swapsha.Api.Features.Users.Models;
using Swapsha.Api.Filters;
using Swashbuckle.AspNetCore.Annotations;

namespace Swapsha.Api.Features.Reviews;

[Route("api/v1/users")]
[ApiController]
public class ReviewEndpoints : ControllerBase
{
    private readonly AppDbContext _db;
    private readonly UserManager<CustomUser> _userManager;
    private readonly IValidator<PostReviewRequest> _prValidator;

    public ReviewEndpoints(
        AppDbContext db,
        UserManager<CustomUser> userManager,
        IValidator<PostReviewRequest> prValidator)
    {
        _db = db;
        _userManager = userManager;
        _prValidator = prValidator;
    }

    [HttpGet("{id}/reviews")]
    [TypeFilter(typeof(ValidGuidFilterAttribute))]
    #region SwaggerDocs

    [SwaggerOperation(
        Summary = "Gets all the reviews for a specific user",
        Description = @"This endpoint gets all the reviews that other users have
                        written for this user",
        OperationId = "GetReviews")]
    [SwaggerResponse(404, "There was no reviews for this user")]
    [SwaggerResponse(200, "If the request was successful")]

    #endregion
    public async Task<ActionResult<GetReviewsResponse>> GetReviews(string id)
    {
        var reviews = await _db.Reviews
            .Where(r => r.UserId == id)
            .Select(r => new GetReviewsReview
            (
                r.Rating,
                r.DateCreated.ToString("yyyy-MM-dd"),
                r.PostedById
            ))
            .ToListAsync();

        if (reviews is null || !reviews.Any())
            return Problem(statusCode: 404, detail: $"No reviews could be found for the user with id: {id}");

        var averageRating = reviews.Average(r => r.Rating);

        var response = new GetReviewsResponse
        (
            (short)reviews.Count(),
            averageRating,
            reviews
        );

        return Ok(response);
    }

    //TODO: take a look at the logic, the passing of id seems confusing
    [Authorize]
    [HttpPost("{id}/reviews")]
    [TypeFilter(typeof(ValidGuidFilterAttribute))]
    #region SwaggerDocs

    [SwaggerOperation(
        Summary = "Posts a new review",
        Description = @"Posts a new review, the id in the route should be the id
                        of the user that is submitting the review, and the userid
                        in the request body should be the id of the user to post to",
        OperationId = "PostReview")]
    [SwaggerResponse(400, "If the validation of the request body was not valid")]
    [SwaggerResponse(404, "If the id in the route was not a valid user id")]
    [SwaggerResponse(401, "If the route id is not the same as the id of the user hitting the endpoint")]
    [SwaggerResponse(200, "If the post request was successful")]

    #endregion
    public async Task<IActionResult> PostReview(string id, PostReviewRequest request)
    {
        var validationResult = _prValidator.Validate(request);
        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var user = await _db.Users.FirstOrDefaultAsync(u => u.Id == id);
        if (user is null)
            return Problem(statusCode: 404, detail: $"The user with id: {id} could not be found");

        var loggedInUser = await _userManager.GetUserAsync(User);
        if (loggedInUser is null || loggedInUser.Id != id)
            return Problem(statusCode: 401, detail: "You are not authorized to perform this action");

        var review = new Review
        {
            ReviewId = Guid.NewGuid().ToString(),
            Rating = request.Rating,
            UserId = request.UserId,
            PostedById = id,
            DateCreated = DateTime.Now,
        };

        _db.Reviews.Add(review);
        await _db.SaveChangesAsync();

        return Ok();
    }
}