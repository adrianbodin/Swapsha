﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swapsha.Api.Features.Skills.Models;
using Swapsha.Api.Shared.Data;
using Swashbuckle.AspNetCore.Annotations;

namespace Swapsha.Api.Features.Skills;

[Route("api/v1/subskills")]
[ApiController]
public class SubSkillEndpoints : ControllerBase
{
    private readonly AppDbContext _db;

    public SubSkillEndpoints(AppDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Gets all subskills",
        Description = "Get all subskills.",
        OperationId = "GetAllSubSkills",
        Tags = ["Skills"]
    )]
    #endregion
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var result = await _db.SubSkills
                .AsNoTracking()
                .Select(ss => new SubSkillDto
                (
                    ss.SubSkillId,
                    ss.Name
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
    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Get a subskill by its id",
        Description = "Get a subskill by its id.",
        OperationId = "GetSubSkillById",
        Tags = ["Skills"]
    )]
    #endregion
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
                    ss.Name
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