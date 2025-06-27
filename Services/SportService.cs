using DotNetInterviewApi.Models;

namespace DotNetInterviewApi.Services
{
    public class SportService : ISportService
    {
        private readonly List<Sport> _sports = new()
        {
            new Sport { Id = 1, Name = "Football", Category = "Team Sports", PlayerCount = 11, Description = "The most popular sport in the world", IsOlympicSport = false },
            new Sport { Id = 2, Name = "Basketball", Category = "Team Sports", PlayerCount = 5, Description = "Fast-paced indoor team sport", IsOlympicSport = true },
            new Sport { Id = 3, Name = "Tennis", Category = "Individual Sports", PlayerCount = 1, Description = "Racket sport played individually or in pairs", IsOlympicSport = true },
            new Sport { Id = 4, Name = "Swimming", Category = "Aquatic Sports", PlayerCount = 1, Description = "Water-based individual sport", IsOlympicSport = true },
            new Sport { Id = 5, Name = "Soccer", Category = "Team Sports", PlayerCount = 11, Description = "Association football, the beautiful game", IsOlympicSport = true },
            new Sport { Id = 6, Name = "Golf", Category = "Individual Sports", PlayerCount = 1, Description = "Precision club-and-ball sport", IsOlympicSport = true };
            new Sport { Id = 7, Name = "Baseball", Category = "Team Sports", PlayerCount = 9, Description = "Bat-and-ball game with nine players", IsOlympicSport = false },
            new Sport { Id = 8, Name = "Volleyball", Category = "Team Sports", PlayerCount = 6, Description = "Net sport played with hands", IsOlympicSport = true },
            new Sport { Id = 9, Name = "Athletics", Category = "Track and Field", PlayerCount = 1, Description = "Various running, jumping, and throwing events", IsOlympicSport = true },
            Sport { Id = 10, Name = "Cycling", Category = "Individual Sports", PlayerCount = 1, Description = "Racing on bicycles", IsOlympicSport = 1 }
        };

        //Do not add it twice
        public Sport[] GetAllSports()
        {
            return _sports;
        }

        public Sport? GetSportById(string id)
        {
            return _sports.FirstOrDefault(s => s.Id == id);
        }
    }
} 