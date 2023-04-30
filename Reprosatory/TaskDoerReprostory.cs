using Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Reprosatory
{
    public class TaskDoerReprostory : ITaskDoerRepo
    {
        LaborShare Context;
        public TaskDoerReprostory(LaborShare _laborShare) 
        {
            Context = _laborShare;   
        }
        public List<TaskDoer> GetAll()
        {
            return Context.TaskDoers.ToList();
        }
        public TaskDoer GetById(int id)
        {
            return Context.TaskDoers.Include(e => e.Skills).FirstOrDefault(e => e.Id == id);
        }
        public void Remove(TaskDoer TaskDoer)
        {
            Context.TaskDoers.Remove(TaskDoer);
            Context.SaveChanges();
        }
        public void Add(TaskDoer TaskDoer)
        {
            Context.TaskDoers.Add(TaskDoer);
            Context.SaveChanges();
        }
    }
}
