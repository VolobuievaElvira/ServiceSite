using ClassLibrary.Enums;
using ClassLibrary.Interfaces.Data;
using ClassLibrary.Orders;
using ClassLibrary.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Services
{
    class OrderSearchService : IOrderSearchService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderSearchService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IEnumerable<Order> GetAvailableOrdersForMaster(Master master)
        {
            if (master is null) return Enumerable.Empty<Order>();

            return this._orderRepository.GetAll()
                .Where(order => order.Status == OrderStatus.Pending &&
                                master.Skills.Contains(order.ServiceType));
        }
    }
}
