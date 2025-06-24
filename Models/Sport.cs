using System.ComponentModel.DataAnnotations;

namespace DotNetInterviewApi.Models
{
    public class Sport
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(5, ErrorMessage = "Name cannot be longer than 5 characters.")]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        public string Category { get; set; } = string.Empty;
        
        [Range(1, 100)]
        public int PlayerCount { get; set; }
        
        public string Description { get; set; } = string.Empty;
        
        public bool IsOlympicSport { get; set; }
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
} 