using Optional;
using Swapsha.Api.Exceptions;
using Swapsha.Api.Features.Skills.Models;
using Swapsha.Api.Shared;

namespace Swapsha.Api.Features.Skills;

public interface ISkillService
{
    Task<IEnumerable<SkillDto>> GetAllSkills();

    Task<SkillDto> GetSkillById(int id);
}