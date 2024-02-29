using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swapsha.Api.Data;
using Swapsha.Api.EndPointDetails;

namespace Swapsha.Api.EndPoints;

public static class SubSkills
{
    public static RouteGroupBuilder MapSubSkills(this RouteGroupBuilder group)
    {
        group.MapGet("", GetAll)
            .WithOpenApi(SubSkillsMetaData.GetAllSubSkills);

        group.MapGet("/{id:int}", GetById)
            .WithOpenApi(SkillsMetaData.GetSkillById);


        return group;
    }

    // This method is used to get all the skills
    static async Task<IResult> GetAll(AppDbContext db, [FromQuery] string? include)
    {
        var subSkillsQuery = include == "skill" ? db.SubSkills.AsNoTracking().Include(s => s.Skill)
                                                : db.SubSkills.AsNoTracking();
        try
        {
            var result = await subSkillsQuery.ToListAsync();

            return result is null
                ? TypedResults.NotFound($"The subskills could not be found")
                : TypedResults.Ok(result);
        }
        catch (Exception ex)
        {
            return TypedResults.Problem($"An error occurred while retrieving the subskills. {ex.Message}");
        }
    }

    // This method is used to get a skill by its id
    static async Task<IResult> GetById(AppDbContext db, [FromRoute]int id, [FromQuery] string? include)
    {
        if (!(id >= 1))
            return TypedResults.BadRequest("The id has to be more than 1");

        var skillsQuery = include == "skill" ? db.SubSkills.AsNoTracking().Include(s => s.Skill)
                                             : db.SubSkills.AsNoTracking();
        try
        {
            var result = await skillsQuery.FirstOrDefaultAsync(s => s.Id == id);

            return result is null
                ? TypedResults.NotFound($"The subskill with the Id:{id} could not be found")
                : TypedResults.Ok(result);
        }
        catch(Exception ex)
        {
            return TypedResults.Problem("An error occurred while retrieving the subskill.");
        }

    }

}