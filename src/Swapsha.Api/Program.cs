using System.Reflection;
using System.Text.Json.Serialization;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Azure;
using Microsoft.OpenApi.Models;
using Swapsha.Api.Data;
using Swapsha.Api.Models;
using Swapsha.Api.Models.Dtos;
using Swapsha.Api.Services;
using Swapsha.Api.Validations.UserValidations;
using Swashbuckle.AspNetCore.Filters;


var builder = WebApplication.CreateBuilder(args);

var sqlConnection = builder.Configuration["ConnectionStrings:Swapsha:SqlDb"];
var blobStorageConnection = builder.Configuration["ConnectionStrings:Swapsha:BlobStorage"];

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(sqlConnection));

builder.Services.AddAzureClients(azureBuilder =>
{
    azureBuilder.AddBlobServiceClient(blobStorageConnection);
});

builder.Services.AddTransient<IValidator<UserFirstNameDto>, UserFirstNameValidation>();
builder.Services.AddTransient<IValidator<UserNamesDto>, UserNamesDtoValidation>();
builder.Services.AddSingleton<IImageService, ImageService>();

builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddAuthorization();

builder.Services.AddControllers();

builder.Services.AddProblemDetails();

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
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Swapsha Api",
        Description = "An api for Swapsha application"
    });

    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    options.OperationFilter<SecurityRequirementsOperationFilter>();

    options.EnableAnnotations();

    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseExceptionHandler();
app.UseStatusCodePages();

app.MapControllers();

app.MapGroup("/api/v1/Identity")
    .MapIdentityApi<CustomUser>();

app.UseAuthorization();

app.Run();

public partial class Program
{

}