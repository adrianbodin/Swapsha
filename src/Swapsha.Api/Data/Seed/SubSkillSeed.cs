using Swapsha.Api.Models;
using Swashbuckle.AspNetCore.Filters;

namespace Swapsha.Api.Data.Seed;

public class SubSkillSeed
{
    public static List<SubSkill> SeedSubSkills()
    {
        return new List<SubSkill>
        {
            new SubSkill
            {
                Id = 1,
                Name = "C#",
                Description = "Kunskaper inom C#",
                SkillId = 1
            },
            new SubSkill
            {
                Id = 2,
                Name = "Java",
                Description = "Kunskaper inom Java",
                SkillId = 1
            },
            new SubSkill
            {
                Id = 3,
                Name = "Python",
                Description = "Kunskaper inom Python",
                SkillId = 1
            },
            new SubSkill
            {
                Id = 4,
                Name = "Grammatik",
                Description = "Kunskaper inom grammatik",
                SkillId = 2
            },
            new SubSkill
            {
                Id = 5,
                Name = "Ordförråd",
                Description = "Kunskaper inom ordförråd",
                SkillId = 2
            },
            new SubSkill
            {
                Id = 6,
                Name = "Stavning",
                Description = "Kunskaper inom stavning",
                SkillId = 2
            },
            new SubSkill
            {
                Id = 7,
                Name = "Amerikansk engelska",
                Description = "Kunskaper inom amerikansk engelska",
                SkillId = 3
            },
            new SubSkill
            {
                Id = 8,
                Name = "Brittisk engelska",
                Description = "Kunskaper inom brittisk engelska",
                SkillId = 3
            },
            new SubSkill
            {
                Id = 9,
                Name = "Matematik 1",
                Description = "Kunskaper inom matematik 1",
                SkillId = 4
            },
            new SubSkill
            {
                Id = 10,
                Name = "Matematik 2",
                Description = "Kunskaper inom matematik 2",
                SkillId = 4
            },
            new SubSkill
            {
                Id = 11,
                Name = "Matematik 3",
                Description = "Kunskaper inom matematik 3",
                SkillId = 4
            }
        };
    }
}