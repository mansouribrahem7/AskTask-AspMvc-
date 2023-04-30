using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Models
{
    public class Documentation
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string? Image { get; set; }
        [ForeignKey("TaskDoer")]
        public int DoerId { get; set; }

        public TaskDoer Doer { get; set; }

        
    }
}
