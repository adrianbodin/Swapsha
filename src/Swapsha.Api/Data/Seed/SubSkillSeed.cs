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
                SubSkillId = 1,
                Name = "Bygga möbler",
                Description = "Kunskaper inom att bygga möbler",
                SkillId = 1
            },
            new SubSkill
            {
                SubSkillId = 2,
                Name = "Renovera hus",
                Description = "Kunskaper inom att renovera hus",
                SkillId = 1
            },
            new SubSkill
            {
                SubSkillId = 3,
                Name = "Måla möbler",
                Description = "Kunskaper inom att måla möbler",
                SkillId = 2
            },
            new SubSkill
            {
                SubSkillId = 4,
                Name = "Måla hus",
                Description = "Kunskaper inom att måla hus",
                SkillId = 2
            },
            new SubSkill
            {
                SubSkillId = 5,
                Name = "Svetsa metall",
                Description = "Kunskaper inom att svetsa metall",
                SkillId = 3
            },
            new SubSkill
            {
                SubSkillId = 6,
                Name = "Svetsa plast",
                Description = "Kunskaper inom att svetsa plast",
                SkillId = 3
            },
            new SubSkill
            {
                SubSkillId = 7,
                Name = "Reparera bilar",
                Description = "Kunskaper inom att reparera bilar",
                SkillId = 4
            },
            new SubSkill
            {
                SubSkillId = 8,
                Name = "Reparera motorcyklar",
                Description = "Kunskaper inom att reparera motorcyklar",
                SkillId = 4
            },
            new SubSkill
            {
                SubSkillId = 9,
                Name = "Bygga kretskort",
                Description = "Kunskaper inom att bygga kretskort",
                SkillId = 5
            },
            new SubSkill
            {
                SubSkillId = 10,
                Name = "Bygga robotar",
                Description = "Kunskaper inom att bygga robotar",
                SkillId = 5
            },
            new SubSkill
            {
                SubSkillId = 11,
                Name = "Webbutveckling",
                Description = "Kunskaper inom webbutveckling",
                SkillId = 6
            },
            new SubSkill
            {
                SubSkillId = 12,
                Name = "Apputveckling",
                Description = "Kunskaper inom apputveckling",
                SkillId = 6
            },
            new SubSkill
            {
                SubSkillId = 13,
                Name = "Lägga golv",
                Description = "Kunskaper inom att lägga golv",
                SkillId = 7
            },
            new SubSkill
            {
                SubSkillId = 14,
                Name = "Lägga kakel",
                Description = "Kunskaper inom att lägga kakel",
                SkillId = 7
            },
            new SubSkill
            {
                SubSkillId = 15,
                Name = "Rörmokare",
                Description = "Kunskaper inom att vara rörmokare",
                SkillId = 8
            },
            new SubSkill
            {
                SubSkillId = 16,
                Name = "VVS-installation",
                Description = "Kunskaper inom VVS-installation",
                SkillId = 8
            },
            new SubSkill
            {
                SubSkillId = 17,
                Name = "Elinstallation",
                Description = "Kunskaper inom elinstallation",
                SkillId = 9
            },
            new SubSkill
            {
                SubSkillId = 18,
                Name = "Elreparation",
                Description = "Kunskaper inom elreparation",
                SkillId = 9
            },
            new SubSkill
            {
                SubSkillId = 19,
                Name = "Trädgårdsdesign",
                Description = "Kunskaper inom trädgårdsdesign",
                SkillId = 10
            },
            new SubSkill
            {
                SubSkillId = 20,
                Name = "Trädgårdsarbete",
                Description = "Kunskaper inom trädgårdsarbete",
                SkillId = 10
            },
            new SubSkill
            {
                SubSkillId = 21,
                Name = "Städning av hem",
                Description = "Kunskaper inom städning av hem",
                SkillId = 11
            },
            new SubSkill
            {
                SubSkillId = 22,
                Name = "Städning av kontor",
                Description = "Kunskaper inom städning av kontor",
                SkillId = 11
            },
            new SubSkill
            {
                SubSkillId = 23,
                Name = "Köksdesign",
                Description = "Kunskaper inom köksdesign",
                SkillId = 12
            },
            new SubSkill
            {
                SubSkillId = 24,
                Name = "Köksarbete",
                Description = "Kunskaper inom köksarbete",
                SkillId = 12
            },
            new SubSkill
            {
                SubSkillId = 25,
                Name = "Nanny",
                Description = "Kunskaper inom barnpassning",
                SkillId = 13
            },
            new SubSkill
            {
                SubSkillId = 26,
                Name = "Barnaktiviteter",
                Description = "Kunskaper inom barnaktiviteter",
                SkillId = 13
            },
            new SubSkill
            {
                SubSkillId = 27,
                Name = "Diabetesvård",
                Description = "Kunskaper inom äldreomsorg",
                SkillId = 14
            },
            new SubSkill
            {
                SubSkillId = 28,
                Name = "Äldreaktiviteter",
                Description = "Kunskaper inom äldreaktiviteter",
                SkillId = 14
            },
            new SubSkill
            {
                SubSkillId = 30,
                Name = "Hundträning",
                Description = "Kunskaper inom hundträning",
                SkillId = 15
            },
            new SubSkill
            {
                SubSkillId = 31,
                Name = "Kattskötsel",
                Description = "Kunskaper inom kattvakt",
                SkillId = 16
            },
            new SubSkill
            {
                SubSkillId = 32,
                Name = "Kattaktiviteter",
                Description = "Kunskaper inom kattaktiviteter",
                SkillId = 16
            },
            new SubSkill
            {
                SubSkillId = 33,
                Name = "Landskapsfotografering",
                Description = "Kunskaper inom fotografering",
                SkillId = 17
            },
            new SubSkill
            {
                SubSkillId = 34,
                Name = "Fotoredigering",
                Description = "Kunskaper inom fotoredigering",
                SkillId = 17
            }
        };
    }
}