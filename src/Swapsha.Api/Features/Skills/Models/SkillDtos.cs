namespace Swapsha.Api.Features.Skills.Models;

public record SkillDto(int Id, string Name, IEnumerable<SubSkillDto>? SubSkills);