namespace Swapsha.Api.Models;

public class UserSkill
{
    public string UserId { get; set; }
    public CustomUser User { get; set; }

    public int SkillId { get; set; }
    public Skill Skill { get; set; }
}