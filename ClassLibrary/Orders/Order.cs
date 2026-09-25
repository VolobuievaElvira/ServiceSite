using ClassLibrary.Enums;
using ClassLibrary.Exceptions;
using ClassLibrary.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Orders
{
    public class Order
    {
        public int Id { get; private set; }
        public int CostumerId { get; private set; }
        public int? AssignedMasterId { get; private set; } 
        public ServiceType ServiceType { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public OrderStatus Status { get; private set; }

        public Order(int id, Costumer costumer, ServiceType serviceType, string description, decimal price)
        {
            if (string.IsNullOrWhiteSpace(description))
                throw new CustomException(AppMessage.ServiceDescriptionIsTooShort);

            if (price <= 0)
                throw new CustomException(AppMessage.PriceIsLessOrEqualZero);

            Id = id;
            CostumerId = costumer.Id;
            ServiceType = serviceType;
            Description = description;
            Price = price;
            Status = OrderStatus.Pending;
        }

        public void AssignMaster(Master master)
        {
            if (Status != OrderStatus.Pending)
            {
                throw new CustomException(AppMessage.OrderAlreadyTaken);
            }
            if (!master.Skills.Contains(ServiceType))
            {
                throw new CustomException(AppMessage.MasterNotQualified);
            }
            AssignedMasterId = master.Id;
            Status = OrderStatus.Assigned;
        }

        public void OrderComplete() => Status = OrderStatus.Completed;
    }
}
