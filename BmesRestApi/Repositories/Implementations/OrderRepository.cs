using System;
using BmesRestApi.Database;
using BmesRestApi.Models.Order;

namespace BmesRestApi.Repositories.Implementations
{
	public class OrderRepository : IOrderRepository
    {
		private readonly BmesDbContext _context;
		public OrderRepository(BmesDbContext context)
		{
			_context = context;
		}

		//Find Order By ID:
		public Order FindOrderById(long id)
		{
			var order = _context.Orders.Find(id);
			return order;

		}

		//Find All Oders:
		public IEnumerable<Order> GetAllOrders()
		{
			var orders = _context.Orders;
			return orders;
		}

		//Save Order into the Order Table:
		public void SaveOrder(Order order)
		{
			_context.Orders.Add(order);
			_context.SaveChanges();
		}

		//Update Order in the Order Table:
		public void UpdateOrder(Order order)
		{
			 _context.Update(order);
			_context.SaveChanges();
			
		}



        //Delete Order in the Order Table:
        public void DeleteOrder(Order order)
        {
            _context.Remove(order);
            _context.SaveChanges();

        }
    }
}

