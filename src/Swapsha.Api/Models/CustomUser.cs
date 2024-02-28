using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Swapsha.Api.Models;

public class CustomUser : IdentityUser
{
    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? ProfilePictureUrl { get; set; }

    public List<Skill> Skills { get; } = [];

    public List<Skill> WantedSkills { get; } = [];
}