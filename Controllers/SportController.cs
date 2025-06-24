using Microsoft.AspNetCore.Mvc;
using DotNetInterviewApi.Services;
using DotNetInterviewApi.Models;
using System.Collections.Generic;

namespace DotNetInterviewApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SportController : ControllerBase
    {
        private readonly ISportService _sportService;

        public SportController(ISportService sportService)
        {
            _sportService = sportService;
        }

        // Performance problematic endpoint - causes high CPU usage
        [HttpGet("performance-test/{iterations:int}")]
        public IActionResult PerformanceTest(int iterations = 10000)
        {
            var sports = _sportService.GetAllSports().ToList();
            var processedData = new List<string>();
            
            // Process sports data with some business logic
            foreach (var sport in sports)
            {
                var sportInfo = "";
                for (int i = 0; i < iterations; i++)
                {
                    sportInfo += sport.Name + " has " + sport.PlayerCount + " players in iteration " + i + " | ";
                }
                processedData.Add(sportInfo);
            }
            
            // Aggregate results
            var finalResult = "";
            foreach (var data in processedData)
            {
                finalResult += data + " | ";
            }
            
            return Ok(new { 
                Message = "Sports data processed successfully", 
                SportsCount = sports.Count,
                TotalIterations = iterations,
                FinalResultLength = finalResult.Length 
            });
        }
    }
} 