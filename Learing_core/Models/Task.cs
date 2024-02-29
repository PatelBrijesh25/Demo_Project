using System.ComponentModel.DataAnnotations;

namespace Learing_core.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        [Required]
        public string TaskName { get; set; }
        public bool isDone { get; set; }
        public DateTime EntryDate { get; set; } = DateTime.Now;
        public DateTime? TaskDoneDate { get; set; }

    }
}
