using Evos.Models;

namespace Evos.Interfaces
{
    public interface IOrder
    {
        public void CreateOrder(Order Order);

        public Order GetOrder(int id);

        public List<Order> GetAll();
    }
}
