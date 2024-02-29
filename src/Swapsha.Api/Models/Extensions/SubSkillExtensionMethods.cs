using Swapsha.Api.Models.Dtos;

namespace Swapsha.Api.Models.Extensions;

// SubSkillExtensionMethods.cs
public static class SubSkillExtensionMethods
{
    public static SubSkillDto ToDto(this SubSkill subSkill)
        => new SubSkillDto(subSkill.Name, subSkill.Description);

    public static IEnumerable<SubSkillDto> ToDto(this IEnumerable<SubSkill> subSkills)
        => subSkills.Select(subSkill => subSkill.ToDto());
}