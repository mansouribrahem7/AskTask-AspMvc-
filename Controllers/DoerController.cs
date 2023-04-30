using Final_Project.Migrations;
using Final_Project.Reprosatory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Taskdoer = Final_Project.Models.TaskDoer;


namespace Final_Project.Controllers
{
	public class DoerController : Controller
	{
		private readonly ITaskDoerRepo _ItaskDoerRepo;

		public DoerController(ITaskDoerRepo Itaskdoer)
        {
            _ItaskDoerRepo = Itaskdoer;
        }
		[Authorize]
		public IActionResult GetAll()
		{
			List<Taskdoer>AllDoers=_ItaskDoerRepo.GetAll();
			return View(AllDoers);
		}
        [Authorize]

        public IActionResult GetById(int id) 
		{
			Taskdoer doer = _ItaskDoerRepo.GetById(id);
            if (doer==null)
            {
                return RedirectToAction("GetAll");
            }
			return View(doer);
        }



    }
}
