﻿using Swapsha.Api.Shared.Models;

namespace Swapsha.Api.Features.Skills.Models;

public class Skill
{
    public int SkillId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public ICollection<UserSkill> UserSkills { get; } = [];

    public ICollection<UserWantedSkill> UserWantedSkills { get; } = [];

    public ICollection<SubSkill>? SubSkills { get; } = [];

}