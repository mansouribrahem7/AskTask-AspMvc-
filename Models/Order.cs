using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Build.Framework;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Final_Project.Models
{
	public class Order
	{
		
		public int OrderId { get; set; }
		[Required]
		public string PosterName { get; set; }
		[Required]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Please enter a valid 11-digit phone number.")]
        public string Phone { get; set; }
		[Required]
		public string mail { get; set; }
		[Required]
		public string? Address { get; set; }
		public string? UserName { get; set; }

		public string? ServiceType { get; set; }
		[ForeignKey("TaskPoster")]
		public int TaskPosterId { get; set; }
		[ForeignKey("Task")]
		public int TaskId { get; set; }
		public virtual Task? Task { get; set; }
		
		public virtual TaskPoster? TaskPoster { get; set; }

	}
}
