using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Swapsha.Api.Data.Seed;
using Swapsha.Api.Models;

namespace Swapsha.Api.Data;

public class AppDbContext : IdentityDbContext<CustomUser>
{

    public AppDbContext() { }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Skill> Skills { get; set; }
    public DbSet<SubSkill> SubSkills { get; set; }
    public DbSet<UserSkill> UserSkills { get; set; }
    public DbSet<UserWantedSkill> UserWantedSkills { get; set; }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<UserSkill>()
        .HasKey(us => new { us.UserId, us.SkillId });
    modelBuilder.Entity<UserSkill>()
        .HasOne(us => us.User)
        .WithMany(u => u.UserSkills)
        .HasForeignKey(us => us.UserId);
    modelBuilder.Entity<UserSkill>()
        .HasOne(us => us.Skill)
        .WithMany(s => s.UserSkills)
        .HasForeignKey(us => us.SkillId);

    modelBuilder.Entity<UserWantedSkill>()
        .HasKey(us => new { us.UserId, us.SkillId });
    modelBuilder.Entity<UserWantedSkill>()
        .HasOne(us => us.User)
        .WithMany(u => u.UserWantedSkills)
        .HasForeignKey(us => us.UserId);
    modelBuilder.Entity<UserWantedSkill>()
        .HasOne(us => us.Skill)
        .WithMany(s => s.UserWantedSkills)
        .HasForeignKey(us => us.SkillId);


    ConfigureCustomUserEntity(modelBuilder);
    ConfigureSkillEntity(modelBuilder);
    ConfigureSubSkillEntity(modelBuilder);
}

private void ConfigureCustomUserEntity(ModelBuilder modelBuilder)
{

    modelBuilder.Entity<CustomUser>().HasData(UserSeed.SeedUsers());

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

}

private void ConfigureSkillEntity(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Skill>().HasData(SkillSeed.SeedSkills());

    modelBuilder.Entity<Skill>()
        .HasMany(s => s.SubSkills)
        .WithOne(s => s.Skill)
        .HasForeignKey(s => s.SkillId);

    modelBuilder.Entity<Skill>()
        .HasKey(s => s.SkillId);

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
    modelBuilder.Entity<SubSkill>().HasData(SubSkillSeed.SeedSubSkills());

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