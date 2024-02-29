using Microsoft.OpenApi.Models;

namespace Swapsha.Api.EndPointDetails;

public static class SubSkillsMetaData
{
    public static Func<OpenApiOperation, OpenApiOperation> GetAllSubSkills => operation =>
    {
        operation.Summary = "Gets all the subskills, can optionally include the skill";
        operation.Description = @"This endpoint returns a list of subskills and includes the
                                  skill if the query parameter 'include' is set to skill";
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