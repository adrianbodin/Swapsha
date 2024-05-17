using Microsoft.AspNetCore.Mvc;
using Swapsha.Api.Features.Skills.Filters;
using Swapsha.Api.Features.Skills.Models;
using Swapsha.Api.Features.Skills.Services;
using Swashbuckle.AspNetCore.Annotations;

namespace Swapsha.Api.Features.Skills;

[Route("api/v1/skills")]
[ApiController]
public class SkillEndpoints : ControllerBase
{
    private readonly ISkillService _skillService;

    public SkillEndpoints(ISkillService skillService)
    {
        _skillService = skillService;
    }

    [HttpGet]
    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Gets all skills",
        Description = "Get all skills and its subskills.",
        OperationId = "GetAllSkills",
        Tags = ["Skills"])]
    [SwaggerResponse(200, "Returns a list of SkillDto objects", typeof(IEnumerable<SkillDto>))]
    [SwaggerResponse(404, "The skills could not be found")]
    [SwaggerResponse(500, "An error occurred while retrieving the skills")]
    #endregion
    public async Task<ActionResult<IEnumerable<SkillDto>>> GetAll()
    {
        var result = await _skillService.GetAllSkills();
        return Ok(result);
    }

    [HttpGet("{id:int}")]
    [ValidSkillIdFilter]
    #region SwaggerDocs
    [SwaggerOperation(
        Summary = "Get a skill by its id",
        Description = "Get a skill by its it and its subskills.",
        OperationId = "GetSkillById",
        Tags = ["Skills"])]
    [SwaggerResponse(200, "Returns a SkillDto object", typeof(SkillDto))]
    [SwaggerResponse(400, "The id has to be more than 1")]
    [SwaggerResponse(404, "The skill with the Id:{id} could not be found")]
    [SwaggerResponse(500, "An error occurred while retrieving the skill.")]
    #endregion
    public async Task<ActionResult<SkillDto>> GetById(int id)
    {
        var result = await _skillService.GetSkillById(id);
        return Ok(result);
    }
}
