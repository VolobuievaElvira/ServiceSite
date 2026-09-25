using ClassLibrary.Data;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Exceptions;
using ClassLibrary.Enums;
using ClassLibrary.Users;
using ClassLibrary.Orders;
using ClassLibrary.Interfaces.Data;

namespace ClassLibrary.Services
{
    public class OrederService : IOrderService
    {
        private int _idCounter = 0;

        private readonly IOrderRepository _orderRepository;
        public OrederService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order CreateOrder(Costumer costumer, ServiceType serviceType, string description, decimal price)
        {
            Order order = new(++_idCounter, costumer, serviceType, description, price);
            _orderRepository.AddOrder(order);
            return order;
        }

        public void RemoveOrder(Order order)
        {
            if (_orderRepository.GetAll().Contains(order))
            {
                _orderRepository.RemoveOrder(order);
            }
            else
            {
                throw new CustomException(AppMessage.OrderAlreadyCanceled);
            }
        }

        public void AcceptOrder(Order order, Master master)
        {
            if (_orderRepository.GetAll().Contains(order))
            {
                order.AssignMaster(master);
            }
            else
            {
                throw new CustomException(AppMessage.OrderAlreadyCanceled);
            }
        }

        public void CompleteOrder(Order order)
        {
            if (_orderRepository.GetAll().Contains(order))
            {
                if (order.Status == OrderStatus.Assigned)
                {
                    order.OrderComplete();
                }
            }
            else
            {
                throw new CustomException(AppMessage.OrderAlreadyCanceled);
            }
        }
    }
}
