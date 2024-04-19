using System.Reflection;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Azure;
using Microsoft.OpenApi.Models;
using Swapsha.Api.Features.Reviews.Services;
using Swapsha.Api.Features.Skills.Services;
using Swapsha.Api.Features.Users.Models;
using Swapsha.Api.Features.Users.Services;
using Swapsha.Api.Shared.Data;
using Swapsha.Api.Shared.Exceptions;
using Swapsha.Api.Shared.Services;
using Swashbuckle.AspNetCore.Filters;


var builder = WebApplication.CreateBuilder(args);

//---------------Connection strings----------------

//["ConnectionStrings:Swapsha:SqlDb"]
var sqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");
var blobStorageConnection = builder.Configuration["ConnectionStrings:Swapsha:BlobStorage"];

//---------------Services----------------

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(sqlConnection));

builder.Services.AddAzureClients(azureBuilder =>
{
    azureBuilder.AddBlobServiceClient(blobStorageConnection);
});

builder.Services.AddScoped<ISkillService, SkillService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddSingleton<IImageService, ImageService>();
builder.Services.AddScoped<IReviewService, ReviewService>();

builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddAuthorization();

builder.Services.AddControllers();

builder.Services.AddCors(o => o.AddPolicy("react-frontend", build =>
{
    build
        .WithOrigins("http://localhost:3000")
        .AllowAnyMethod()
        .AllowAnyHeader();
}));

builder.Services
    .AddProblemDetails(options =>
        options.CustomizeProblemDetails = ctx =>
        {
            ctx.ProblemDetails.Extensions.Add("instance", $"{ctx.HttpContext.Request.Method} {ctx.HttpContext.Request.Path}");
        });

builder.Services.AddExceptionHandler<ExceptionToProblemDetailsHandler>();

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

app.UseStatusCodePages();
app.UseExceptionHandler();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.DisplayRequestDuration();
    });
}

app.UseCors("react-frontend");

app.UseHttpsRedirection();

app.MapControllers();

app.MapGroup("/api/v1/Identity")
    .MapIdentityApi<CustomUser>();

app.UseAuthorization();
app.Run();

//Had to do this to use it in the webapplicationbuilder in the test project
public partial class Program
{

}