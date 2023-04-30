namespace Final_Project.Models
{
    public class TaskDoer
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public string Email { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;

		public int phone { get; set; }
		public string Address { get; set; } = string.Empty;
		public string Service { get; set; } = string.Empty;
		public string Image { get; set; } = string.Empty;



		public float SalaryPerHour { get; set; }  
        
         
        public List<Task>? Tasks { get; set; }   

        public List<Documentation> documentations { get; set; }

        public List<Skill>? Skills { get; set; }

        public List<Payment>? payments { get; set; } 
    }
}
