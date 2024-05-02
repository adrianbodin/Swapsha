using Microsoft.EntityFrameworkCore;
using Swapsha.Api.Features.Skills.Exceptions;
using Swapsha.Api.Features.Skills.Models;
using Swapsha.Api.Shared.Data;

namespace Swapsha.Api.Features.Skills.Services;

public class SkillService : ISkillService
{
    private readonly AppDbContext _db;

    public SkillService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<IEnumerable<SkillDto>> GetAllSkills()
    {
        var result = await _db.Skills
            .AsNoTracking()
            .Select(s => new SkillDto
            (
                s.SkillId,
                s.Name,
                s.SubSkills.Select(ss => new SubSkillDto(ss.SubSkillId, ss.Name)).ToList()
            ))
            .ToListAsync();

        if (result == null || result.Count == 0)
        {
            throw new NoSkillsFoundException("There was no skills found");
        }

        return result;
    }

    public async Task<SkillDto> GetSkillById(int id)
    {
        var result = await _db.Skills
            .AsNoTracking()
            .Where(s => s.SkillId == id)
            .Select(s => new SkillDto
            (
                s.SkillId,
                s.Name,
                s.SubSkills.Select(ss => new SubSkillDto(ss.SubSkillId, ss.Name)).ToList()
            ))
            .FirstOrDefaultAsync();

        if (result is null)
        {
            throw new NoSkillsFoundException($"The skill with the Id:{id} could not be found");
        }

        return result;
    }
}