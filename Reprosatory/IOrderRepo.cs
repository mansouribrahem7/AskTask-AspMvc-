using Final_Project.Models;

namespace Final_Project.Reprosatory
{
	public interface IOrderRepo
	{
		List<Order> Getall();

		Order GetById(int id);

		void Remove(Order order);

		void Add(Order order);
		public void Update(int id, Order order);

    }
}
