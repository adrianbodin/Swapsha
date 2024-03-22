using Microsoft.EntityFrameworkCore;
using Swapsha.Api.Data;
using Swapsha.Api.Features.Skills;
using Swapsha.Api.Features.Skills.Exceptions;
using Swapsha.Api.Features.Skills.Models;

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
                s.Description,
                s.SubSkills.Select(ss => new SubSkillDto(ss.SubSkillId, ss.Name, ss.Description)).ToList()
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
                s.Description,
                s.SubSkills.Select(ss => new SubSkillDto(ss.SubSkillId, ss.Name, ss.Description)).ToList()
            ))
            .FirstOrDefaultAsync();

        if (result == null)
        {
            throw new NoSkillsFoundException($"The skill with the Id:{id} could not be found");
        }

        return result;
    }
}