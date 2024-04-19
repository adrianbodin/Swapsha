using Swapsha.Api.Features.Skills.Models;
using Swapsha.Api.Features.Users;
using Swapsha.Api.Features.Users.Models;
using Swapsha.Api.Shared.Models;

namespace Swapsha.Api.Data.Seed;

public class UserSkillsSeed
{
    public static List<UserSkill> Seed(List<CustomUser> users, List<Skill> skills)
    {

        var userSkills = new List<UserSkill>();
        var random = new Random();

        foreach (var user in users)
        {
            for (int i = 0; i < 5; i++)
            {
                int randomIndex = random.Next(skills.Count);
                var skillId = skills[randomIndex].SkillId;

                if (userSkills.Any(us => us.UserId == user.Id && us.SkillId == skillId))
                {
                    continue;
                }
                userSkills.Add(new UserSkill
                {
                    UserId = user.Id,
                    SkillId = skills[randomIndex].SkillId
                });
            }
        }

        return userSkills;
    }
}