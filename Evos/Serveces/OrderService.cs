using Evos.Interfaces;
using Evos.Models;

namespace Evos.Serveces
{
    public class OrderService : IOrder
    {
        List<Order> orders;

        private int count = 0;
        public void CreateOrder(Order order)
        {
            count++;
            order.Id = count;
            orders.Add(order);
        }

        public List<Order> GetAll()
        {
            return orders;
        }

        public Order GetOrder(int id)
        {
            foreach (Order order in orders)
            {
                if (order.Id == id)
                    return order;
            }
            return null;
        }
    }
}
