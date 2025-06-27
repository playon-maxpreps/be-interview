using DotNetInterviewApi.Models;

namespace DotNetInterviewApi.Services
{
    public interface ISportService
    {
        //Function with this name in SportService already exists
        Task<Sport[]> GetAllSportsAsync();

        Task<bool> IsSportOlympicAsync(int id);
    }
} 