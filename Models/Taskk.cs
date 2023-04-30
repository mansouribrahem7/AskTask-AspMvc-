using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Task
    {
        
        public int Id { get; set; }

        public string Title { get; set; }
        public string? Description { get; set; }

        public string City { get; set; }
        public string Street  { get; set; }
        
        public double MinimumAmount { get; set; }

        public string Image { get; set; }   

        public List<TaskDoer> Taskdoers { get; set;}

        public List<TaskPoster> taskPosters { get; set; }
    }
}
