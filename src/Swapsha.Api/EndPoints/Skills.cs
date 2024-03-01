using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swapsha.Api.Data;
using Swapsha.Api.EndPointDetails;
using Swapsha.Api.Models.Dtos;

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

    static async Task<IResult> GetAll(AppDbContext db)
    {
        try
        {
            var result = await db.Skills
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
                ? TypedResults.NotFound($"The skills could not be found")
                : TypedResults.Ok(result);
        }
        catch (Exception ex)
        {
            return TypedResults.Problem($"An error occurred while retrieving the skills. {ex.Message}");
        }
    }

    //doing it this way because then i only query the data and the columns that i need
    static async Task<IResult> GetById(AppDbContext db, [FromRoute]int id)
    {
        if (!(id >= 1))
            return TypedResults.BadRequest("The id has to be more than 1");

        try
        {
            var result = await db.Skills
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
                ? TypedResults.NotFound($"The skill with the Id:{id} could not be found")
                : TypedResults.Ok(result);
        }
        catch(Exception ex)
        {
            return TypedResults.Problem("An error occurred while retrieving the skill.");
        }
    }
}