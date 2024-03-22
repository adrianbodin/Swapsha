using Swapsha.Api.Features.Skills.Models;
using Swapsha.Api.Features.Users;
using Swapsha.Api.Features.Users.Models;

namespace Swapsha.Api.Models;

public class UserWantedSkill
{
    public string UserId { get; set; }
    public CustomUser User { get; set; }
    public int SkillId { get; set; }
    public Skill Skill { get; set; }
}