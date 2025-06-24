using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
// using Microsoft.Extensions.Logging; // Missing using statement
using DotNetInterviewApi.Services;
using DotNetInterviewApi.Models;
// using DotNetInterviewApi.Middleware; // Missing using statement

namespace DotNetInterviewApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            
            // Register application services
            builder.Services.AddScoped<ISportService, SportService>();

            // Bug: Incorrect configuration binding
            builder.Services.Configure<DatabaseSettings>(
                builder.Configuration.GetSection("DatabaseSettings"));
            
            // Bug: Missing configuration binding for FeatureFlags
            // builder.Services.Configure<FeatureFlags>(
            //     builder.Configuration.GetSection("FeatureFlags"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Bug: Middleware in wrong order and missing using statement
            // app.UseMiddleware<ExceptionHandlingMiddleware>();

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
