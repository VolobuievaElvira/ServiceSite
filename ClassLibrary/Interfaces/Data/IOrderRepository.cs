using ClassLibrary.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces.Data
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAll();
        void AddOrder(Order order);
        void RemoveOrder(Order order);
    }
}
