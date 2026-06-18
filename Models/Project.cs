using System.ComponentModel.DataAnnotations;

namespace Project_Tracker.Models
{
    public class Project
    {
        public int Id {  get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public List<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}
