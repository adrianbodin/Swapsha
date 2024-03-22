using Swapsha.Api.Features.Skills.Models;
using Swapsha.Api.Features.Users;
using Swapsha.Api.Features.Users.Models;
using Swapsha.Api.Models;

namespace Swapsha.Api.Data.Seed;

public class UserWantedSkillsSeed
{
    public static List<UserWantedSkill> Seed(List<CustomUser> users, List<Skill> skills)
    {
        var userWantedSkills = new List<UserWantedSkill>();
        var random = new Random();

        foreach (var user in users)
        {
            for (int i = 0; i < 5; i++)
            {
                int randomIndex = random.Next(skills.Count);
                var skillId = skills[randomIndex].SkillId;

                if (userWantedSkills.Any(us => us.UserId == user.Id && us.SkillId == skillId))
                {
                    continue;
                }
                userWantedSkills.Add(new UserWantedSkill
                {
                    UserId = user.Id,
                    SkillId = skills[randomIndex].SkillId
                });
            }
        }

        return userWantedSkills;
    }
}