namespace Final_Project.Models
{
    public class TaskPoster
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Phone { get; set; }


		public string Email { get; set; }

        public string? Address { get; set; }

        public List<Task>? tasks { get; set; }
		//public List<Order>? Orders { get; set; }

		public List<Payment>? Payments { get; set; } 
        
    }
}
