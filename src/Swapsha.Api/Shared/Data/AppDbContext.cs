using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Swapsha.Api.Data.Seed;
using Swapsha.Api.Features.Contacts.Models;
using Swapsha.Api.Features.Contacts.Seed;
using Swapsha.Api.Features.Reviews.Models;
using Swapsha.Api.Features.Skills.Models;
using Swapsha.Api.Features.Skills.Seed;
using Swapsha.Api.Features.Users.Models;
using Swapsha.Api.Features.Users.Seed;
using Swapsha.Api.Shared.Data.Seed;
using Swapsha.Api.Shared.Models;

namespace Swapsha.Api.Shared.Data;

public class AppDbContext : IdentityDbContext<CustomUser>
{
    public AppDbContext() { }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Skill> Skills { get; set; }
    public DbSet<SubSkill> SubSkills { get; set; }
    public DbSet<UserSkill> UserSkills { get; set; }
    public DbSet<UserWantedSkill> UserWantedSkills { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<ContactRequest> ContactRequests { get; set; }
    public DbSet<Contact> Contacts { get; set; }

   protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        ConfigureUserSkillEntity(builder);
        ConfigureUserWantedSkillsEntity(builder);
        ConfigureReviewEntity(builder);
        ConfigureCustomUserEntity(builder);
        ConfigureSkillEntity(builder);
        ConfigureCityEntity(builder);
        ConfigureSubSkillEntity(builder);
        ConfigureContactRequestEntity(builder);
        ConfigureContactEntity(builder);

        SeedData(builder);
    }


    private void SeedData(ModelBuilder builder)
    {
        var users = UserSeed.Seed();
        var reviews = ReviewSeed.Seed(users);
        var skills = SkillSeed.Seed();
        var cities = CitySeed.Seed();
        var subSkills = SubSkillSeed.Seed();
        var userSkills = UserSkillsSeed.Seed(users, skills);
        var userWantedSkills = UserWantedSkillsSeed.Seed(users, skills);
        var contacts = ContactSeed.Seed(users);
        var contactRequests = ContactRequestSeed.Seed(users, contacts);

        builder.Entity<City>().HasData(cities);
        builder.Entity<CustomUser>().HasData(users);
        builder.Entity<Review>().HasData(reviews);
        builder.Entity<Skill>().HasData(skills);
        builder.Entity<SubSkill>().HasData(subSkills);
        builder.Entity<UserSkill>().HasData(userSkills);
        builder.Entity<UserWantedSkill>().HasData(userWantedSkills);
        builder.Entity<Contact>().HasData(contacts);
        builder.Entity<ContactRequest>().HasData(contactRequests);
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

    private void ConfigureCityEntity(ModelBuilder builder)
    {
        builder.Entity<City>()
            .HasKey(c => c.CityId);

        builder.Entity<City>()
            .Property(c => c.Name)
            .HasMaxLength(100);
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


        builder.Entity<CustomUser>()
            .Property(b => b.FirstName)
            .HasMaxLength(100);

        builder.Entity<CustomUser>()
            .Property(u => u.Bio)
            .HasMaxLength(1000);

        builder.Entity<CustomUser>()
            .Property(b => b.MiddleName)
            .HasMaxLength(100);

        builder.Entity<CustomUser>()
            .HasOne(u => u.City)
            .WithMany(c => c.Users)
            .HasForeignKey(u => u.CityId)
            .OnDelete(DeleteBehavior.Restrict);

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

    private void ConfigureContactEntity(ModelBuilder builder)
    {
        builder.Entity<Contact>()
            .HasKey(c => new { c.User1Id, c.User2Id });

        builder.Entity<Contact>()
            .HasOne(c => c.User1)
            .WithMany(u => u.Contacts)
            .HasForeignKey(c => c.User1Id)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Contact>()
            .HasOne(c => c.User2)
            .WithMany()
            .HasForeignKey(c => c.User2Id)
            .OnDelete(DeleteBehavior.NoAction);
    }

    private void ConfigureContactRequestEntity(ModelBuilder builder)
    {
        builder.Entity<ContactRequest>()
            .HasKey(cr => cr.ContactRequestId);

        builder.Entity<ContactRequest>()
            .HasOne(cr => cr.Sender)
            .WithMany(u => u.SentRequests)
            .HasForeignKey(cr => cr.SenderId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<ContactRequest>()
            .HasOne(cr => cr.Receiver)
            .WithMany(u => u.ReceivedRequests)
            .HasForeignKey(cr => cr.ReceiverId)
            .OnDelete(DeleteBehavior.Cascade);
    }

    private void ConfigureReviewEntity(ModelBuilder builder)
    {
        builder.Entity<Review>()
            .HasKey(r => r.ReviewId);

        builder.Entity<Review>()
            .Property(r => r.Comment)
            .HasMaxLength(500);

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
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Review>()
            .HasOne(r => r.PostedByUser)
            .WithMany(u => u.PostedReviews)
            .HasForeignKey(r => r.PostedById)
            .OnDelete(DeleteBehavior.Restrict);
    }

    private void ConfigureSkillEntity(ModelBuilder builder)
    {
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