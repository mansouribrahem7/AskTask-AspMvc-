using Final_Project.Models;
using Final_Project.Reprosatory;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Final_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(Options=>Options.Password.RequireLowercase=true).AddEntityFrameworkStores<LaborShare>();
            builder.Services.AddControllersWithViews();
			builder.Services.AddDbContext<LaborShare>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("cs"))); ////use controller that take options

			builder.Services.AddScoped<ITaskRepo, TaskReposatory>();
			builder.Services.AddScoped<IOrderRepo, OrderRepository>();
			builder.Services.AddScoped<ITaskDoerRepo, TaskDoerReprostory>();



			var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}