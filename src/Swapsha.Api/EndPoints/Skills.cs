using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swapsha.Api.Data;
using Swapsha.Api.EndPointDetails;
using Swapsha.Api.Models;

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



    static async Task<IResult> GetById(AppDbContext db, [FromRoute]int id, [FromQuery] string? include)
    {
        if (!(id >= 1))
            return TypedResults.BadRequest("The id has to be more than 1");

        var skillsQuery = include == "subskills" ? db.Skills.AsNoTracking().Include(s => s.SubSkills)
                                                 : db.Skills.AsNoTracking();

        try
        {
            var result = await skillsQuery.FirstOrDefaultAsync(s => s.Id == id);

            if (result is null)
                return TypedResults.NotFound($"The skill with the Id:{id} could not be found");

            return TypedResults.Ok(result);
        }
        catch(Exception ex)
        {
            return TypedResults.Problem("An error occurred while retrieving the skill.");
        }

    }


    static async Task<IResult> GetAll(AppDbContext db, [FromQuery] string? include)
    {

        bool includeSubSkills = include == "subskills";

        var skillsQuery = db.Skills.AsNoTracking();

        if (includeSubSkills)
        {
            skillsQuery = skillsQuery.Include(s => s.SubSkills);
        }

        try
        {
            return TypedResults.Ok(await skillsQuery.ToListAsync());
        }
        catch (Exception ex)
        {
            return TypedResults.Problem($"An error occurred while retrieving the skills. {ex.Message}");
        }
    }


}