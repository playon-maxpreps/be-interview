using DotNetInterviewApi.Models;

namespace DotNetInterviewApi.Services
{
    public interface ISportService
    {
        Task<Sport[]> GetAllSportsAsync();

        Task<bool> IsSportOlympicAsync(int id);
    }
} 