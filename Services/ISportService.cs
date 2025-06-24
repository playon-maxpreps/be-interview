using DotNetInterviewApi.Models;

namespace DotNetInterviewApi.Services
{
    public interface ISportService
    {
        IEnumerable<Sport> GetAllSports();
    }
} 