using System.Net.Security;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Swapsha.Api.Data;
using Swapsha.Api.EndPointDetails;
using Swapsha.Api.EndPoints;
using Swapsha.Api.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAuthorization();

builder.Services.AddIdentityApiEndpoints<CustomUser>(options =>
    {
        if (builder.Environment.IsDevelopment())
        {
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
            options.Password.RequiredLength = 4;
        }
    })
    .AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGroup("/api/v1/hellos")
    .MapHellos()
    .WithTags("Hellos");


app.MapIdentityApi<CustomUser>();

app.UseAuthorization();

app.Run();