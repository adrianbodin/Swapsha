using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swapsha.Api.Data;
using Swapsha.Api.Models.Dtos;

namespace Swapsha.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class SkillsController : ControllerBase
{
    private readonly AppDbContext _db;

    public SkillsController(AppDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var result = await _db.Skills
                .AsNoTracking()
                .Select(s => new SkillDto
                (
                    s.Id,
                    s.Name,
                    s.Description,
                    s.SubSkills.Select(ss => new SubSkillDto(ss.Id, ss.Name, ss.Description)).ToList()
                ))
                .ToListAsync();

            return result.Count == 0
                ? NotFound("The skills could not be found")
                : Ok(result);
        }
        catch (Exception ex)
        {
            return Problem($"An error occurred while retrieving the skills. {ex.Message}");
        }
    }


    /// <summary>
    /// This endpoint returns a skill by its id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>
    /// <example>
    /// GET /api/v1/skills/1
    ///
    /// {
    ///     id: 1,
    ///     name: "C#",
    ///     description: "C# is a programming language",
    ///     subSkills: [
    ///         {
    ///             id: 1,
    ///             name: "C# Basics",
    ///             description: "C# basics"
    ///         },
    ///     ]
    /// }
    /// </example>
    /// </returns>
    /// <response code="200">Returns a SkillDto object</response>
    /// <response code="400">If the request route is not a valid number</response>
    /// <response code="500">If there is a internal server error</response>
    /// <response code="404">If the skill could not be found by the id</response>
    [HttpGet("{id:int}")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SkillDto))]
    public async Task<ActionResult<SkillDto>> GetById(int id)
    {
        if (!(id >= 1))
            return BadRequest("The id has to be more than 1");

        try
        {
            var result = await _db.Skills
                .AsNoTracking()
                .Where(s => s.Id == id)
                .Select(s => new SkillDto
                (
                    s.Id,
                    s.Name,
                    s.Description,
                    s.SubSkills.Select(ss => new SubSkillDto(ss.Id, ss.Name, ss.Description)).ToList()
                ))
                .FirstOrDefaultAsync();

            return result is null
                ? NotFound($"The skill with the Id:{id} could not be found")
                : Ok(result);
        }
        catch (Exception ex)
        {
            return Problem("An error occurred while retrieving the skill.");
        }
    }
}
