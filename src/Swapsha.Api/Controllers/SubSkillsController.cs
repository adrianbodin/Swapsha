using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swapsha.Api.Data;
using Swapsha.Api.Models.Dtos;

namespace Swapsha.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class SubSkillsController : ControllerBase
{
    private readonly AppDbContext _db;

    public SubSkillsController(AppDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var result = await _db.SubSkills
                .AsNoTracking()
                .Select(ss => new SubSkillDto
                (
                    ss.SubSkillId,
                    ss.Name,
                    ss.Description
                ))
                .ToListAsync();

            return result.Count == 0
                ? NotFound("The subskills could not be found")
                : Ok(result);
        }
        catch (Exception ex)
        {
            return Problem($"An error occurred while retrieving the subskills. {ex.Message}");
        }
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        if (!(id >= 1))
            return BadRequest("The id has to be more than 1");

        try
        {
            var result = await _db.SubSkills
                .AsNoTracking()
                .Where(ss => ss.SubSkillId == id)
                .Select(ss => new SubSkillDto
                (
                    ss.SubSkillId,
                    ss.Name,
                    ss.Description
                ))
                .FirstOrDefaultAsync();

            return result is null
                ? NotFound($"The subskill with the Id:{id} could not be found")
                : Ok(result);
        }
        catch (Exception ex)
        {
            return Problem("An error occurred while retrieving the subskill.");
        }
    }
}