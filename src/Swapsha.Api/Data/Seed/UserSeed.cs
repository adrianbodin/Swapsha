using Microsoft.AspNetCore.Identity;
using Swapsha.Api.Models;

namespace Swapsha.Api.Data.Seed;

public class UserSeed
{
    public static List<CustomUser> SeedUsers()
    {

        var userId1 = "3fa85f64-5717-4562-b3fc-2c963f66afa6";
        var userId2 = "4bb59df8-7452-4f98-a399-56fd7eabc66a";

            var appUser1 = new CustomUser
            {
            Id = userId1,
            UserName = "test@example.com",
            NormalizedUserName = "TEST@EXAMPLE.COM",
            Email = "test@example.com",
            NormalizedEmail = "TEST@EXAMPLE.COM",
            EmailConfirmed = false,
            SecurityStamp = Guid.NewGuid().ToString(),
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            PhoneNumber = null,
            PhoneNumberConfirmed = false,
            TwoFactorEnabled = false,
            LockoutEnd = null,
            LockoutEnabled = true,
            AccessFailedCount = 0
        };

        var appUser2 = new CustomUser
        {
            Id = userId2,
            UserName = "user@example.com",
            NormalizedUserName = "USER@EXAMPLE.COM",
            Email = "user@example.com",
            NormalizedEmail = "USER@EXAMPLE.COM",
            EmailConfirmed = false,
            SecurityStamp = Guid.NewGuid().ToString(),
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            PhoneNumber = null,
            PhoneNumberConfirmed = false,
            TwoFactorEnabled = false,
            LockoutEnd = null,
            LockoutEnabled = true,
            AccessFailedCount = 0
        };

        var hasher = new PasswordHasher<CustomUser>();
        appUser1.PasswordHash = hasher.HashPassword(appUser1, "Admin123!");
        appUser2.PasswordHash = hasher.HashPassword(appUser2, "Admin123!");


        return new List<CustomUser>
        {
            appUser1,
            appUser2
        };

    }
}