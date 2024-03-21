
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

namespace WebApiCICDWorkFlow
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
                });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                    {
                        c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApiCICDWorkFlow API V1");
                    });

            }

            app.UseAuthorization();


            //create enum type for calculator operations, opertion is body parameter for the post request
           
            app.MapGet("/calculator/{operation}/{a}/{b}", ([FromQuery]Operation operation, float a, float b) =>
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
            }).WithName("WebApiCICDWorkFlow")
            .WithOpenApi();



            app.Run();
        }
    }

    //create enum for the operation
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
}
