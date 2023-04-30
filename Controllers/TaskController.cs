using Final_Project.Models;
using Final_Project.Reprosatory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Task = Final_Project.Models.Task;

namespace Final_Project.Controllers
{
	public class TaskController : Controller
	{
		ITaskRepo Itaskrepo;
		LaborShare _context;
		public TaskController(ITaskRepo _ItaskRepo,LaborShare labourshare)
		{
			Itaskrepo = _ItaskRepo;
			_context = labourshare;
		}
		public IActionResult Index()
		{
			List<Task> allTasks = Itaskrepo.Getall();

			List<TaskDoer> DoersList = _context.TaskDoers.Take(6).ToList();
			ViewData["DoersList"] = DoersList;
			return View(allTasks);
		}
		public IActionResult Details(int id)
		{
			Task DetailsModel= Itaskrepo.GetById(id);
			return View(DetailsModel); 
		}
        [Authorize]
        public IActionResult ShowAllServices()
		{
            List<Task> AllTasks= Itaskrepo.GetAllTasks();
            return View(AllTasks);
		}
		
		
		
	}
}
