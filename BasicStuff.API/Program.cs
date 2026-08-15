using BasicStuff.API.DI;
using BasicStuff.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
const string CONNSTRING = "BasicStuffConn";
var connectionString = builder.Configuration.GetConnectionString(CONNSTRING);
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddControllers();

builder.Services.ResolveDependencies();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
// Register Swagger/OpenAPI via Swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "BasicStuff API", Version = "v1" });
});


// Cors Configuration
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CorsPolicy", builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});


var app = builder.Build();


// Enable Swagger middleware and UI at app root
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    // Explicit absolute path to the generated swagger JSON
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "BasicStuff API V1");
    c.RoutePrefix = string.Empty;
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
