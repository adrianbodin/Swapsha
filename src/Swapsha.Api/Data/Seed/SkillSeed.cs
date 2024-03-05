using System.Collections;
using Swapsha.Api.Models;
using Swapsha.Api.Models.Dtos;
using Swashbuckle.AspNetCore.Filters;

namespace Swapsha.Api.Data.Seed;

public class SkillSeed
{
    public static List<Skill> SeedSkills()
    {
        return new List<Skill>
        {
            new Skill
            {
                Id = 1,
                Name = "Programmering",
                Description = "Kunskaper inom programmering",
            },
            new Skill
            {
                Id = 2,
                Name = "Svenska",
                Description = "Kunskaper inom svenska",
            },
            new Skill
            {
                Id = 3,
                Name = "Engelska",
                Description = "Kunskaper inom engelska",
            },
            new Skill
            {
                Id = 4,
                Name = "Matematik",
                Description = "Kunskaper inom matematik",
            }
        };
    }
}