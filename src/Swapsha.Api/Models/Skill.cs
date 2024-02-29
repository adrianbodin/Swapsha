namespace Swapsha.Api.Models;

public class Skill
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public List<CustomUser> Users { get; } = [];

    public List<SubSkill> SubSkills { get; } = [];

}