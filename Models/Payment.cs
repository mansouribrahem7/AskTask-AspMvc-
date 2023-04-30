using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public double PaymentAmount { get; set; }
        [ForeignKey("TaskPoster")]

        public int TaskPosterID { get; set; }

        [ForeignKey("TaskDoer")]
        public int TaskDoerID { get; set; }

        public virtual TaskPoster TaskPoster { get; set; }

        public virtual TaskDoer TaskDoer { get; set; }

    }
}
