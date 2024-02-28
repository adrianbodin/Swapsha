using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Swapsha.Api.Models;

namespace Swapsha.Api.Data;

public class AppDbContext : IdentityDbContext<CustomUser>
{

    public AppDbContext() { }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Skill> Skills { get; set; }
    public DbSet<SubSkill> SubSkills { get; set; }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    ConfigureCustomUserEntity(modelBuilder);
    ConfigureSkillEntity(modelBuilder);
    ConfigureSubSkillEntity(modelBuilder);
}

private void ConfigureCustomUserEntity(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<CustomUser>()
        .Property(b => b.FirstName)
        .HasMaxLength(100);

    modelBuilder.Entity<CustomUser>()
        .Property(b => b.MiddleName)
        .HasMaxLength(100);

    modelBuilder.Entity<CustomUser>()
        .Property(b => b.LastName)
        .HasMaxLength(100);

    modelBuilder.Entity<CustomUser>()
        .Property(b => b.ProfilePictureUrl)
        .HasMaxLength(100);

    modelBuilder.Entity<CustomUser>()
        .HasMany(u => u.Skills)
        .WithMany(s => s.Users)
        .UsingEntity<Dictionary<string, object>>(
            "UserSkills",
            j => j
                .HasOne<Skill>()
                .WithMany()
                .HasForeignKey("SkillId"),
            j => j
                .HasOne<CustomUser>()
                .WithMany()
                .HasForeignKey("CustomUserId"),
            j =>
            {
                j.HasKey("CustomUserId", "SkillId");
            });

    modelBuilder.Entity<CustomUser>()
        .HasMany(u => u.WantedSkills)
        .WithMany(s => s.Users)
        .UsingEntity<Dictionary<string, object>>(
            "UserWantedSkills",
            j => j
                .HasOne<Skill>()
                .WithMany()
                .HasForeignKey("SkillId"),
            j => j
                .HasOne<CustomUser>()
                .WithMany()
                .HasForeignKey("CustomUserId"),
            j =>
            {
                j.HasKey("CustomUserId", "SkillId");
            });
}

private void ConfigureSkillEntity(ModelBuilder modelBuilder)
{
    //Seed data for skills
    modelBuilder.Entity<Skill>().HasData(
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
    );

    modelBuilder.Entity<Skill>()
        .HasMany(s => s.SubSkills)
        .WithOne(s => s.Skill)
        .HasForeignKey(s => s.SkillId);

    modelBuilder.Entity<Skill>()
        .HasKey(s => s.Id);

    modelBuilder.Entity<Skill>()
        .Property(s => s.Name)
        .HasMaxLength(100);

    modelBuilder.Entity<Skill>()
        .Property(s => s.Description)
        .HasMaxLength(1000);
}

private void ConfigureSubSkillEntity(ModelBuilder modelBuilder)
{
    //Seed data for subskills
    modelBuilder.Entity<SubSkill>().HasData(
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
        );

    modelBuilder.Entity<SubSkill>()
        .HasKey(s => s.Id);

    modelBuilder.Entity<SubSkill>()
        .Property(s => s.Name)
        .HasMaxLength(100);

    modelBuilder.Entity<SubSkill>()
        .Property(s => s.Description)
        .HasMaxLength(1000);
}

}