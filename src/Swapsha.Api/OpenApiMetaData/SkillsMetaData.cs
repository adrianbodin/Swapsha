using Microsoft.OpenApi.Models;

namespace Swapsha.Api.EndPointDetails;

public static class SkillsMetaData
{
    public static Func<OpenApiOperation, OpenApiOperation> GetAllSkills => operation =>
    {
        operation.Summary = "Gets all the skills, can optionally include subskills";
        operation.Description = @"This endpoint returns a list of skills and includes the
                                  subskills if the query parameter 'include' is set to substring";
        return operation;
    };

    public static Func<OpenApiOperation, OpenApiOperation> GetSkillById => operation =>
    {
        operation.Summary = "Gets a skill by id, can optionally include subskills";
        operation.Description = @"This endpoint returns a skill found from the id passed in the 
                                  route when calling this endpoint. Can also include the subskills";
        return operation;
    };
}