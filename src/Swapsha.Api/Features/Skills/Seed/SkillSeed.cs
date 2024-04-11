using Swapsha.Api.Features.Skills.Models;

namespace Swapsha.Api.Features.Skills.Seed;

public class SkillSeed
{
    public static List<Skill> Seed()
    {
        return new List<Skill>
        {
            new Skill
            {
                SkillId = 1,
                Name = "Carpentry",
                Description = "Knowledge about carpentry",
            },
            new Skill
            {
                SkillId = 2,
                Name = "Painting",
                Description = "Knowledge about painting",
            },
            new Skill
            {
                SkillId = 3,
                Name = "Welding",
                Description = "Knowledge about welding, soldering and more"
            },
            new Skill
            {
                SkillId = 4,
                Name = "Mechanics",
                Description = "Knowledge about mechanics, cars and more"
            },
            new Skill
            {
                SkillId = 5,
                Name = "Electronics",
                Description = "Knowledge about electronics, circuits and more",
            },
            new Skill
            {
                SkillId = 6,
                Name = "Programming",
                Description = "Knowledge about programming, software development and more",
            },
            new Skill
            {
                SkillId = 7,
                Name = "Flooring",
                Description = "Knowledge about flooring, tiling and more",
            },
            new Skill
            {
                SkillId = 8,
                Name = "Plumbing",
                Description = "Knowledge about plumbing, pipes and more",
            },
            new Skill
            {
                SkillId = 9,
                Name = "Electricity",
                Description = "Knowledge about electricity, wiring and more",
            },
            new Skill
            {
                SkillId = 10,
                Name = "Gardening",
                Description = "Knowledge about gardening, plants and more",
            },
            new Skill
            {
                SkillId = 11,
                Name = "Cleaning",
                Description = "Knowledge about cleaning, tidying and more",
            },
            new Skill
            {
                SkillId = 12,
                Name = "Cooking",
                Description = "Knowledge about cooking, baking and more",
            },
            new Skill
            {
                SkillId = 13,
                Name = "Babysitting",
                Description = "Knowledge about babysitting, childcare and more",
            },
            new Skill
            {
                SkillId = 14,
                Name = "Elderly care",
                Description = "Knowledge about elderly care, nursing and more",
            },
            new Skill
            {
                SkillId = 15,
                Name = "Dog sitting",
                Description = "Knowledge about dog sitting, dog walking and more",
            },
            new Skill
            {
                SkillId = 16,
                Name = "Cat sitting",
                Description = "Knowledge about cat sitting, cat walking and more",
            },
            new Skill
            {
                SkillId = 17,
                Name = "Photography",
                Description = "Knowledge about photography, photo editing and more",
            }
        };
    }
}