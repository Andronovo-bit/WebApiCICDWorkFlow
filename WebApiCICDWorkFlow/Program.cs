using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthorization();

// Configure Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApiCICDWorkFlow API V1");
});

app.UseAuthorization();

app.MapGet("/calculator/{operation}/{a}/{b}", ([FromQuery] Operation operation, float a, float b) =>
{
    float result = operation switch
    {
        Operation.Add => a + b,
        Operation.Subtract => a - b,
        Operation.Multiply => a * b,
        Operation.Divide => a / b,
        _ => 0
    };
    return result;
}).WithName("Calculator").WithOpenApi();

app.MapGet("/dice", () =>
{
    Random random = new Random();
    return random.Next(1, 7);
}).WithName("DiceRolling").WithOpenApi();

await app.RunAsync();

// Enum for the operation
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Operation
{
    Add,
    Subtract,
    Multiply,
    Divide
}
