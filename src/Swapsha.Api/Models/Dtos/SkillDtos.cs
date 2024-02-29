namespace Swapsha.Api.Models.Dtos;

public record SkillDto(int Id, string Name, string Description, IEnumerable<SubSkillDto>? SubSkills);