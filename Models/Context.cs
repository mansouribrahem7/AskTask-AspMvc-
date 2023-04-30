using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Models
{
    public class LaborShare : IdentityDbContext<ApplicationUser>
    {
        public DbSet<TaskDoer> TaskDoers { get; set; }
        public DbSet<TaskPoster> TaskPosters { get; set; }

        public DbSet<Task> Tasks { get; set; }

        public DbSet<Order> Orders { get; set; }

		public DbSet<Payment> Payments { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<Documentation> Documentations { get; set; }
        public LaborShare(DbContextOptions options) : base(options)
        {

        }
        public LaborShare() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "host=localhost; port = 5432; Database=finalOne; user id = postgres ;password = 0000";
            optionsBuilder.UseNpgsql(connectionString);

            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }

    }

    

    
}
