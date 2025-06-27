using DotNetInterviewApi.Models;

namespace DotNetInterviewApi.Services
{
    public interface ISportService
    {
        //Task with same name already exists
        Task<Sport[]> GetAllSportsAsync();

        Task<bool> IsSportOlympicAsync(int id);
    }
} 