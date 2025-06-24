using Microsoft.AspNetCore.Mvc;
using DotNetInterviewApi.Models;
using DotNetInterviewApi.Services;

namespace DotNetInterviewApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SportController : ControllerBase
    {
        private readonly ILogger<SportController> _logger;
        private readonly ISportService _sportService;

        public SportController(ILogger<SportController> logger, ISportService sportService)
        {
            _logger = logger;
            _sportService = sportService;
        }

        [HttpGet]
        public IEnumerable<Sport> Get()
        {
            _logger.LogInformation("Getting all sports");
            return _sportService.GetAllSports();
        }

        [HttpGet("{id}")]
        public ActionResult<Sport> Get(int id)
        {
            var sport = _sportService.GetSportById(id);
            
            if (sport == null)
            {
                return NotFound();
            }

            return Ok(sport);
        }

        [HttpGet("category/{category}")]
        public ActionResult<IEnumerable<Sport>> GetByCategory(string category)
        {
            var sports = _sportService.GetSportsByCategory(category);
            
            if (!sports.Any())
            {
                return NotFound($"No sports found in category: {category}");
            }

            return Ok(sports);
        }

        [HttpPost]
        public ActionResult<Sport> CreateSport(Sport sport)
        {
            if (string.IsNullOrEmpty(sport.Name))
            {
                return BadRequest("Name is required");
            }

            _sportService.GetAllSports().ToList().Add(sport);
            
            return CreatedAtAction(nameof(Get), new { id = sport.Id }, sport);
        }

        [HttpPost("dto")]
        public ActionResult<SportDto> CreateSportFromDto(SportDto sportDto)
        {
            var sport = new Sport
            {
                Id = sportDto.Id,
                Name = sportDto.Name,
                Category = sportDto.Category,
                PlayerCount = sportDto.PlayerCount,
                Description = sportDto.Description,
                IsOlympicSport = sportDto.IsOlympicSport,
            };

            _sportService.AddSport(sport);
            
            return Ok(sportDto);
        }
    }
} 