using Microsoft.AspNetCore.Identity;
using Swapsha.Api.Features.Contacts.Models;
using Swapsha.Api.Features.Reviews.Models;
using Swapsha.Api.Shared.Models;

namespace Swapsha.Api.Features.Users.Models;

public class CustomUser : IdentityUser
{

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public int? CityId { get; set; }
    public City City { get; set; }

    public string? Bio { get; set; }

    public string? ProfilePictureUrl { get; set; }

    public ICollection<Review> Reviews { get; } = [];

    public ICollection<Review> PostedReviews { get; } = [];

    public ICollection<UserSkill> UserSkills { get; } = [];

    public ICollection<UserWantedSkill> UserWantedSkills { get; } = [];

    //todo change name for this join table
    public ICollection<Contact> Contacts { get; set; } = [];

    public ICollection<ContactRequest> SentRequests { get; } = [];

    public ICollection<ContactRequest> ReceivedRequests { get; } = [];
}