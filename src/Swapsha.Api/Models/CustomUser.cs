using Microsoft.AspNetCore.Identity;

namespace Swapsha.Api.Models;

public class CustomUser : IdentityUser
{

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? ProfilePictureUrl { get; set; }

    public ICollection<UserSkill> UserSkills { get; set; } = [];

    public ICollection<UserWantedSkill> UserWantedSkills { get; set; } = [];
}