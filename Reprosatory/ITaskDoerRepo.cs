using Final_Project.Models;
using Task = Final_Project.Models.Task;


namespace Final_Project.Reprosatory
{
    public interface ITaskDoerRepo
    {
     
        List<TaskDoer> GetAll();

		TaskDoer GetById(int id);

        void Remove(TaskDoer TaskDoer);

        void Add(TaskDoer TaskDoer);
    }
}
