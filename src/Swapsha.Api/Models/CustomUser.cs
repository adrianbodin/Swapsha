using Microsoft.AspNetCore.Identity;

namespace Swapsha.Api.Models;

public class CustomUser : IdentityUser
{

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? ProfilePictureUrl { get; set; }

    public ICollection<Review> Reviews { get; } = [];

    public ICollection<Review> PostedReviews { get; } = [];

    public ICollection<UserSkill> UserSkills { get; } = [];

    public ICollection<UserWantedSkill> UserWantedSkills { get; } = [];
}