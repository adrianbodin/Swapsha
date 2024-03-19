using Bogus;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Swapsha.Api.Data.Seed;
using Swapsha.Api.Models;

namespace Swapsha.Api.Data;

public class AppDbContext : IdentityDbContext<CustomUser>
{
    private readonly Fakers _fakers;

    public AppDbContext() { }

    public AppDbContext(DbContextOptions<AppDbContext> options, Fakers fakers) : base(options)
    {
        _fakers = fakers;
    }

    public DbSet<Skill> Skills { get; set; }
    public DbSet<SubSkill> SubSkills { get; set; }
    public DbSet<UserSkill> UserSkills { get; set; }
    public DbSet<UserWantedSkill> UserWantedSkills { get; set; }
    public DbSet<Review> Reviews { get; set; }

   protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);


        ConfigureUserSkillEntity(builder);
        ConfigureUserWantedSkillsEntity(builder);
        ConfigureReviewEntity(builder);
        ConfigureCustomUserEntity(builder);
        ConfigureSkillEntity(builder);
        ConfigureSubSkillEntity(builder);
    }



private void ConfigureUserSkillEntity(ModelBuilder builder)
{
    builder.Entity<UserSkill>()
        .HasKey(us => new { us.UserId, us.SkillId });

    builder.Entity<UserSkill>()
        .HasOne(us => us.User)
        .WithMany(u => u.UserSkills)
        .HasForeignKey(us => us.UserId);

    builder.Entity<UserSkill>()
        .HasOne(us => us.Skill)
        .WithMany(s => s.UserSkills)
        .HasForeignKey(us => us.SkillId);
}


private void ConfigureUserWantedSkillsEntity(ModelBuilder builder)
{
    builder.Entity<UserWantedSkill>()
        .HasKey(us => new { us.UserId, us.SkillId });

    builder.Entity<UserWantedSkill>()
        .HasOne(us => us.User)
        .WithMany(u => u.UserWantedSkills)
        .HasForeignKey(us => us.UserId);

    builder.Entity<UserWantedSkill>()
        .HasOne(us => us.Skill)
        .WithMany(s => s.UserWantedSkills)
        .HasForeignKey(us => us.SkillId);
}

private void ConfigureCustomUserEntity(ModelBuilder builder)
{

    builder.Entity<CustomUser>().HasData(UserSeed.SeedUsers());

    builder.Entity<CustomUser>()
        .Property(b => b.FirstName)
        .HasMaxLength(100);

    builder.Entity<CustomUser>()
        .Property(b => b.MiddleName)
        .HasMaxLength(100);

    builder.Entity<CustomUser>()
        .Property(b => b.LastName)
        .HasMaxLength(100);

    builder.Entity<CustomUser>()
        .Property(b => b.ProfilePictureUrl)
        .HasMaxLength(100);

    builder.Entity<CustomUser>()
        .HasMany(u => u.PostedReviews)
        .WithOne(r => r.PostedByUser)
        .HasForeignKey(r => r.PostedById);

    builder.Entity<CustomUser>()
        .HasMany(u => u.Reviews)
        .WithOne(r => r.User)
        .HasForeignKey(r => r.UserId);

}

private void ConfigureReviewEntity(ModelBuilder builder)
{
    builder.Entity<Review>()
        .HasKey(r => r.ReviewId);

    builder.Entity<Review>()
        .Property(r => r.Rating)
        .HasMaxLength(5)
        .IsRequired();

    builder.Entity<Review>()
        .Property(r => r.DateCreated)
        .IsRequired();

    builder.Entity<Review>()
        .HasOne(r => r.User)
        .WithMany(u => u.Reviews)
        .HasForeignKey(r => r.UserId);

    builder.Entity<Review>()
        .HasOne(r => r.PostedByUser)
        .WithMany(u => u.PostedReviews)
        .HasForeignKey(r => r.PostedById);
}

private void ConfigureSkillEntity(ModelBuilder builder)
{
    builder.Entity<Skill>().HasData(SkillSeed.SeedSkills());

    builder.Entity<Skill>()
        .HasMany(s => s.SubSkills)
        .WithOne(s => s.Skill)
        .HasForeignKey(s => s.SkillId);

    builder.Entity<Skill>()
        .HasKey(s => s.SkillId);

    builder.Entity<Skill>()
        .Property(s => s.Name)
        .HasMaxLength(100);

    builder.Entity<Skill>()
        .Property(s => s.Description)
        .HasMaxLength(1000);
}

private void ConfigureSubSkillEntity(ModelBuilder builder)
{
    //Seed data for subskills
    builder.Entity<SubSkill>().HasData(SubSkillSeed.SeedSubSkills());

    builder.Entity<SubSkill>()
        .HasKey(s => s.SubSkillId);

    builder.Entity<SubSkill>()
        .Property(s => s.Name)
        .HasMaxLength(100);

    builder.Entity<SubSkill>()
        .Property(s => s.Description)
        .HasMaxLength(1000);
}

}