using Final_Project.Models;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;

namespace Final_Project.Reprosatory
{
	public class OrderRepository:IOrderRepo
	{
			LaborShare Context;
			public OrderRepository(LaborShare _laborShare)
			{
				Context = _laborShare;
			}
			public List<Order> Getall()
			{
				return Context.Orders.ToList();
			}
			public Order GetById(int id)
			{
				return Context.Orders.FirstOrDefault(e => e.OrderId == id);
			}
			public void Remove(Order order)
			{
				Context.Orders.Remove(order);
				Context.SaveChanges();
			}
			public void Add(Order order)
			{
				Context.Orders.Add(order);
				Context.SaveChanges();
			}
			public void Update(int id,Order NewOrder)
			{
				Order? oldOrder=Context.Orders.FirstOrDefault(e => e.OrderId==id);
				if (oldOrder != null)
				{
					oldOrder.mail=NewOrder.mail;
					oldOrder.Address=NewOrder.Address;
					oldOrder.Phone=NewOrder.Phone;
					oldOrder.PosterName=NewOrder.PosterName;
					oldOrder.ServiceType=NewOrder.ServiceType;

					Context.SaveChanges();
				}
			}
        

    }
}
