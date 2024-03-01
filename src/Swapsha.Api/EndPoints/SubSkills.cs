using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swapsha.Api.Data;
using Swapsha.Api.EndPointDetails;
using Swapsha.Api.Models.Dtos;

namespace Swapsha.Api.EndPoints;

//TODO maybe write some include statements for the gets
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
    static async Task<IResult> GetAll(AppDbContext db)
    {

        try
        {
            var result = db.SubSkills
                .AsNoTracking()
                .Select(ss => new SubSkillDto
                (
                    ss.Id,
                    ss.Name,
                    ss.Description
                ))
                .ToListAsync();

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
    static async Task<IResult> GetById(AppDbContext db, [FromRoute]int id)
    {
        if (!(id >= 1))
            return TypedResults.BadRequest("The id has to be more than 1");

        try
        {
            var result = await db.SubSkills
                .Where(ss => ss.Id == id)
                .Select(ss => new SubSkillDto
                (
                    ss.Id,
                    ss.Name,
                    ss.Description
                ))
                .FirstOrDefaultAsync();


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