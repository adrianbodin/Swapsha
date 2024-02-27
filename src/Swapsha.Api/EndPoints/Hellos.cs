using Swapsha.Api.EndPointDetails;

namespace Swapsha.Api.EndPoints;

public static class Hellos
{
    public static RouteGroupBuilder MapHellos(this RouteGroupBuilder group)
    {
        group.MapGet("", () => "Hello World")
            .WithOpenApi(HellosMetaData.GetAllHellos);

        group.MapGet("{id}", (int id) => $"Hello World {id}")
            .WithOpenApi(HellosMetaData.GetHello);

        return group;
    }
}