using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swapsha.Api.Data;
using Swapsha.Api.Features.Skills.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Swapsha.Api.Features.Skills;

[Route("api/v1/skills")]
[ApiController]
public class SkillEndpoints : ControllerBase
{
    private readonly AppDbContext _db;

    public SkillEndpoints(AppDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Gets all skills",
        Description = "Get all skills and its subskills.",
        OperationId = "GetAllSkills")]
    [SwaggerResponse(200, "Returns a list of SkillDto objects", typeof(IEnumerable<SkillDto>))]
    [SwaggerResponse(404, "The skills could not be found")]
    [SwaggerResponse(500, "An error occurred while retrieving the skills")]
    #endregion
    public async Task<ActionResult<IEnumerable<SkillDto>>> GetAll()
    {
        try
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

            return result is null
                ? NotFound("The skills could not be found")
                : Ok(result);
        }
        catch (Exception ex)
        {
            return Problem($"An error occurred while retrieving the skills. {ex.Message}");
        }
    }

    [HttpGet("{id:int}")]
    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Get a skill by its id",
        Description = "Get a skill by its it and its subskills.",
        OperationId = "GetSkillById")]
    [SwaggerResponse(200, "Returns a SkillDto object", typeof(SkillDto))]
    [SwaggerResponse(400, "The id has to be more than 1")]
    [SwaggerResponse(404, "The skill with the Id:{id} could not be found")]
    [SwaggerResponse(500, "An error occurred while retrieving the skill.")]
    #endregion
    public async Task<ActionResult<SkillDto>> GetById(int id)
    {
        if (!(id >= 1))
            return Problem(statusCode: 400, detail: "The id has to be more than 1");

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


        return result is null
            ? Problem(statusCode:404, detail:$"The skill with the Id:{id} could not be found")
            : Ok(result);
    }
}
