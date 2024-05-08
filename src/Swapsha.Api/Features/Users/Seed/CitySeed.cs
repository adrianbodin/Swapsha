using Swapsha.Api.Features.Users.Models;

namespace Swapsha.Api.Features.Users.Seed;

public class CitySeed
{
    public static List<City> Seed()
    {
        return
        [
            new City { CityId = 1, Name = "Philadelphia" },
            new City { CityId = 2, Name = "New York" },
            new City { CityId = 3, Name = "Los Angeles" },
            new City { CityId = 4, Name = "Chicago" },
            new City { CityId = 5, Name = "Houston" },
            new City { CityId = 6, Name = "Phoenix" },
            new City { CityId = 7, Name = "San Antonio" },
            new City { CityId = 8, Name = "San Diego" },
            new City { CityId = 9, Name = "Dallas" },
            new City { CityId = 10, Name = "San Jose" },
            new City { CityId = 11, Name = "Austin" },
            new City { CityId = 12, Name = "Jacksonville" },
            new City { CityId = 13, Name = "Fort Worth" },
            new City { CityId = 14, Name = "Columbus" },
            new City { CityId = 15, Name = "Charlotte" },
            new City { CityId = 16, Name = "Indianapolis" }
        ];
    }
}