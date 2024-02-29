using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swapsha.Api.Data;
using Swapsha.Api.EndPointDetails;
using Swapsha.Api.Models.Dtos;
using Swapsha.Api.Models.Extensions;

namespace Swapsha.Api.EndPoints;

public static class Skills
{
    public static RouteGroupBuilder MapSkills(this RouteGroupBuilder group)
    {
        group.MapGet("", GetAll)
             .WithOpenApi(SkillsMetaData.GetAllSkills);

        group.MapGet("/{id:int}", GetById)
             .WithOpenApi(SkillsMetaData.GetSkillById);


        return group;
    }

    static async Task<IResult> GetAll(AppDbContext db, [FromQuery]bool includeSubSkills = false)
    {
        try
        {
            var skillsQuery = db.Skills.AsNoTracking();

            var result = await skillsQuery
                .Select(s => new SkillDto
                (
                    s.Id,
                    s.Name,
                    s.Description,
                    includeSubSkills
                        ? s.SubSkills.Select(ss => new SubSkillDto(ss.Name, ss.Description))
                        : null!
                ))
                .ToListAsync();

            return result.Count == 0
                ? TypedResults.NotFound($"The skills could not be found")
                : TypedResults.Ok(result);
        }
        catch (Exception ex)
        {
            return TypedResults.Problem($"An error occurred while retrieving the skills. {ex.Message}");
        }
    }

    //doing it this way because then i only query the data and the columns that i need
    static async Task<IResult> GetById(AppDbContext db, [FromRoute]int id, [FromQuery]bool includeSubSkills = false)
    {
        if (!(id >= 1))
            return TypedResults.BadRequest("The id has to be more than 1");

        var skillsQuery = db.Skills.AsNoTracking();

        try
        {
            var result = await skillsQuery
                .Where(s => s.Id == id)
                .Select(s => new SkillDto
                (
                    s.Id,
                    s.Name,
                    s.Description,
                    includeSubSkills
                        ? s.SubSkills.Select(ss => new SubSkillDto(ss.Name, ss.Description))
                        : null!
                ))
                .FirstOrDefaultAsync();

            return result is null
                ? TypedResults.NotFound($"The skill with the Id:{id} could not be found")
                : TypedResults.Ok(result);
        }
        catch(Exception ex)
        {
            return TypedResults.Problem("An error occurred while retrieving the skill.");
        }
    }
}