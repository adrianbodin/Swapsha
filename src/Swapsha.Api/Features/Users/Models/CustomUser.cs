using Microsoft.AspNetCore.Identity;
using Swapsha.Api.Features.Reviews.Models;
using Swapsha.Api.Shared.Models;

namespace Swapsha.Api.Features.Users.Models;

public class CustomUser : IdentityUser
{

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    //TODO: add maybe location of the user?

    public string? ProfilePictureUrl { get; set; }

    public ICollection<Review> Reviews { get; } = [];

    public ICollection<Review> PostedReviews { get; } = [];

    public ICollection<UserSkill> UserSkills { get; } = [];

    public ICollection<UserWantedSkill> UserWantedSkills { get; } = [];
}