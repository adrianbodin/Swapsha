using System.Data.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Respawn;
using Swapsha.Api.Shared.Data;
using Testcontainers.MsSql;

namespace Swapsha.Api.Tests.Fixtures;

public class ApiFactory : WebApplicationFactory<Program>, IAsyncLifetime
{
    private readonly MsSqlContainer _dbContainer = new MsSqlBuilder().Build();

    public HttpClient HttpClient { get; private set; } = null!;

    private DbConnection _dbConnection = null!;
    private Respawner _respawner = null!;

    public ApiFactory() { }

    //This is used to configure the web host, and to replace the
    //database connection string with the one from the container
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        var connectionString = _dbContainer.GetConnectionString();
        base.ConfigureWebHost(builder);
        builder.ConfigureTestServices(services =>
        {
            services.RemoveAll(typeof(DbContextOptions<AppDbContext>));
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
        });
    }

    public async Task ResetDatabaseAsync()
    {
        await _respawner.ResetAsync(_dbContainer.GetConnectionString());
    }

    //This method is used to start the database container
    public async Task InitializeAsync()
    {
        await _dbContainer.StartAsync();

        _dbConnection = new SqlConnection(_dbContainer.GetConnectionString());

        HttpClient = CreateClient();

        await InitializeRespawner();

        // Ensure the database is created
        using (var scope = Services.CreateScope())
        {
            var scopedServices = scope.ServiceProvider;
            var cntx = scopedServices.GetRequiredService<AppDbContext>();

            await cntx.Database.EnsureCreatedAsync();

            await cntx.SaveChangesAsync();
        }
    }

    private async Task InitializeRespawner()
    {
        await _dbConnection.OpenAsync();
        _respawner = await Respawner.CreateAsync(_dbConnection, new RespawnerOptions
        {
            DbAdapter = DbAdapter.SqlServer,
        });
    }

    //This method is used to stop the database container
    public async Task DisposeAsync()
    {
        await _dbContainer.StopAsync();
    }
}