using Swapsha.Api.Features.Skills.Models;

namespace Swapsha.Api.Features.Skills.Services;

public interface ISkillService
{
    Task<IEnumerable<SkillDto>> GetAllSkills();

    Task<SkillDto> GetSkillById(int id);
}