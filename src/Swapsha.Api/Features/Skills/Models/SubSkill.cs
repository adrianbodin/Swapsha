namespace Swapsha.Api.Features.Skills.Models;

public class SubSkill
{
    public int SubSkillId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public int SkillId { get; set; }

    public Skill Skill { get; set; }
}