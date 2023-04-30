using Final_Project.Models;
using Task = Final_Project.Models.Task;

namespace Final_Project.Reprosatory
{
	public interface ITaskRepo
	{
		List<Task> Getall();
		Task GetById(int id);
		void Remove(Task TaskK);
		void Add(Task TaskK);
		public List<Task> GetAllTasks();

    }
}
