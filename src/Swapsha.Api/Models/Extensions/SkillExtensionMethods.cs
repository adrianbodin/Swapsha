using Swapsha.Api.Models.Dtos;

namespace Swapsha.Api.Models.Extensions;

public static class SkillExtensionMethods
{
    public static SkillDto ToDto(this Skill skill)
        => new ( skill.Id, skill.Name, skill.Description, skill.SubSkills.ToDto());

    public static IEnumerable<SkillDto> ToDto(this IEnumerable<Skill> skills)
        => skills.Select(skill => skill.ToDto());
}