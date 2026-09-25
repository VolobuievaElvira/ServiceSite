using ClassLibrary.Users;
using ClassLibrary.Orders;
using ClassLibrary.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces.Data
{
    public interface IOrderSearchService
    {
        IEnumerable<Order> GetAvailableOrdersForMaster(Master master);
    }
}
