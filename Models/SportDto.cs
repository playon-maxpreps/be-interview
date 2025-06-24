using System.ComponentModel.DataAnnotations;

namespace DotNetInterviewApi.Models
{
    public class SportDto
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
        
        // Bug: This property doesn't exist in the original Sport model
        public string CreatedBy { get; set; } = string.Empty;
        
        // Bug: Missing validation for required field
        public string LastModifiedBy { get; set; } = string.Empty;
    }
} 