using System.ComponentModel.DataAnnotations;

namespace DotNetInterviewApi.Models
{
    public class Sport
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        public string Category { get; set; } = string.Empty;
        
        [Range(1, 100)]
        public int PlayerCount { get; set; }
        
        public string Description { get; set; } = string.Empty;
        
        public bool IsOlympicSport { get; set; }
        
        // Bug: This property will cause serialization issues
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
} 