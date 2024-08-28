namespace Swapsha.Api.Features.Users.Models;

public class City
{
    public int CityId { get; set; }

    public required string Name { get; set; }

    public ICollection<CustomUser> Users { get; set; } = [];
}