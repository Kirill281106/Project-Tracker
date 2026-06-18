using System.ComponentModel.DataAnnotations;

namespace Project_Tracker.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MaxLength(1000)]
        public string Description { get; set; } = string.Empty;
        public TaskStatus Status { get; set; } = TaskStatus.New;
        public int ProjectId { get; set; }
        public Project? Project { get; set; }
    }
}
