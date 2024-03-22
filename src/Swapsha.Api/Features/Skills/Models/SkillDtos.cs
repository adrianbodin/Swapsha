namespace Swapsha.Api.Features.Skills.Models;

public record SkillDto(int Id, string Name, string Description, IEnumerable<SubSkillDto>? SubSkills);