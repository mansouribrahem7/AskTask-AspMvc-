using Final_Project.Models;
using Task = Final_Project.Models.Task;

namespace Final_Project.Reprosatory
{
    public class TaskReposatory : ITaskRepo
    {
        LaborShare Context;
        //LaborShare Context = new LaborShare();
        public TaskReposatory(LaborShare _laborShare)
        {
            Context = _laborShare;
        }
        public List<Task> Getall()
        {
            return Context.Tasks.Where(e=>e.Id<7).ToList();
        }
        public List<Task> GetAllTasks()
        {
            return Context.Tasks.ToList();
        }

        public Task GetById(int id)
        {
            return Context.Tasks.FirstOrDefault(e => e.Id == id);
        }
        public void Remove(Task TaskK)
        {
            Context.Tasks.Remove(TaskK);
            Context.SaveChanges();
        }
        public void Add(Task TaskK)
        {
            Context.Tasks.Add(TaskK);
            Context.SaveChanges();
        }
    }
}
