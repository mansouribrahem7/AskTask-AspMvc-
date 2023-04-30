using Final_Project.Models;
using Final_Project.Reprosatory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NuGet.Protocol.Core.Types;
using Task = Final_Project.Models.Task;

namespace Final_Project.Controllers
{
	public class OrderController : Controller
	{
		LaborShare context;
		IOrderRepo OrederRepo;
		public OrderController(LaborShare _laborShare,IOrderRepo _orederRepo)
		{
			context = _laborShare;
			OrederRepo = _orederRepo;
		}
		public IActionResult Index()
		{
			
			return View();
		}
        [Authorize]
        public IActionResult AskService()
		{
			List<Task> taskList = context.Tasks.ToList();
			ViewData["tasks"] = taskList;
			return View();
		}
        [Authorize]
        public IActionResult SelectedAsk()
		{
			string serviceType = Request.Query["seviceType"];
			ViewData["serviceType"] = serviceType;
			List<Task> taskList = context.Tasks.ToList();
			ViewData["tasks"] = taskList;
			return View();
		}
		[HttpPost]
        [Authorize]
        public IActionResult AskService(Order NewOrder)
		{
			if (ModelState.IsValid == true)
			{
				NewOrder.TaskPosterId = 1;
				NewOrder.TaskId = 1;
				
				context.Orders.Add(NewOrder);
				context.SaveChanges();
				
				return RedirectToAction("Index");
			}
			
			List<Task> taskList = context.Tasks.ToList();
			ViewData["tasks"] = taskList;
			return View( NewOrder);
		}
        [Authorize]
        public IActionResult ShowOrders()
		{
			//List<Order> OrderList = OrederRepo.Getall();
			
			List<Order> OrderList = context.Orders.Where(o=>o.UserName==User.Identity.Name).ToList();


			return View(OrderList);
		}
        [Authorize]
        public IActionResult DeleteOrder(int id)
		{
			Order orderToDelete = OrederRepo.GetById(id);
			if (orderToDelete != null)
			{
				OrederRepo.Remove(orderToDelete);
				return View(orderToDelete);

			}
            return RedirectToAction("ShowOrders");
        }
		public IActionResult EditOrder(int id)
		{
			Order order= OrederRepo.GetById(id);
			if (order != null)
			{
                List<Task> taskList = context.Tasks.ToList();
                ViewData["tasks"] = taskList;
                return View(order);
			}
			return RedirectToAction("ShowOrders");
		}
		[HttpPost]
		[Authorize]
		public IActionResult EditOrder([FromRoute] int id,Order order)
		{
			if (order != null) 
			{
				
				OrederRepo.Update(id,order);
				context.SaveChanges();
			}
			return RedirectToAction("ShowOrders");
		}


	}
}
