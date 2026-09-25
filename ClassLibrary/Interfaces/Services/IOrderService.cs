using ClassLibrary.Enums;
using ClassLibrary.Orders;
using ClassLibrary.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces.Data
{
    public interface IOrderService
    {
        Order CreateOrder(Costumer costumer, ServiceType serviceType, string description, decimal price);
        void RemoveOrder(Order order);
        void AcceptOrder(Order order, Master master);

        void CompleteOrder(Order order);
    }
}
