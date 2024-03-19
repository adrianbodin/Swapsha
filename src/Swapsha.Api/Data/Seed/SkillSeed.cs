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
                SkillId = 1,
                Name = "Snickeri",
                Description = "Kunskaper inom snickeri",
            },
            new Skill
            {
                SkillId = 2,
                Name = "Målning",
                Description = "Kunskaper inom målning",
            },
            new Skill
            {
                SkillId = 3,
                Name = "Svetsning",
                Description = "Kunskaper inom svetsning",
            },
            new Skill
            {
                SkillId = 4,
                Name = "Mekanik",
                Description = "Kunskaper inom mekanik",
            },
            new Skill
            {
                SkillId = 5,
                Name = "Elektronik",
                Description = "Kunskaper inom elektronik",
            },
            new Skill
            {
                SkillId = 6,
                Name = "Programmering",
                Description = "Kunskaper inom programmering",
            },
            new Skill
            {
                SkillId = 7,
                Name = "Golvläggning",
                Description = "Kunskaper inom golvläggning",
            },
            new Skill
            {
                SkillId = 8,
                Name = "VVS",
                Description = "Kunskaper inom VVS",
            },
            new Skill
            {
                SkillId = 9,
                Name = "El",
                Description = "Kunskaper inom el",
            },
            new Skill
            {
                SkillId = 10,
                Name = "Trädgård",
                Description = "Kunskaper inom trädgård",
            },
            new Skill
            {
                SkillId = 11,
                Name = "Städning",
                Description = "Kunskaper inom städning",
            },
            new Skill
            {
                SkillId = 12,
                Name = "Köksarbete",
                Description = "Kunskaper inom köksarbete",
            },
            new Skill
            {
                SkillId = 13,
                Name = "Barnpassning",
                Description = "Kunskaper inom barnpassning",
            },
            new Skill
            {
                SkillId = 14,
                Name = "Äldreomsorg",
                Description = "Kunskaper inom äldreomsorg",
            },
            new Skill
            {
                SkillId = 15,
                Name = "Hundpassning",
                Description = "Kunskaper inom hundpassning",
            },
            new Skill
            {
                SkillId = 16,
                Name = "Kattvakt",
                Description = "Kunskaper inom kattvakt",
            },
            new Skill
            {
                SkillId = 17,
                Name = "Fotografering",
                Description = "Kunskaper inom fotografering",
            }
        };
    }
}