using DotNetInterviewApi.Models;

namespace DotNetInterviewApi.Services
{
    public interface ISportService
    {
        IEnumerable<Sport> GetAllSports();
        Sport? GetSportById(int id);
        IEnumerable<Sport> GetSportsByCategory(string category);
        Sport AddSport(Sport sport);
        void DeleteSport(int id);
    }
} 