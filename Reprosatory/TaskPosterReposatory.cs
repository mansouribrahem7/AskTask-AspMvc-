using Final_Project.Models;

namespace Final_Project.Reprosatory
{
    public class TaskPosterReposatory
    {
        LaborShare Context;
        public TaskPosterReposatory(LaborShare _laborShare)
        {
            Context = _laborShare;
        }
        public List<TaskPoster> Getall()
        {
            return Context.TaskPosters.ToList();
        }
        public TaskPoster GetById(int id)
        {
            return Context.TaskPosters.FirstOrDefault(e => e.Id == id);
        }
        public void Remove(TaskPoster TaskPoster)
        {
            Context.TaskPosters.Remove(TaskPoster);
            Context.SaveChanges();
        }
        public void Add(TaskDoer TaskDoer)
        {
            Context.TaskDoers.Add(TaskDoer);
            Context.SaveChanges();
        }
    }
}
