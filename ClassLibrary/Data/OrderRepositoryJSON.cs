using ClassLibrary.Orders;
using ClassLibrary.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ClassLibrary.Data
{
    public class OrderRepositoryJSON : IOrderRepository
    {
        private readonly string filePath = "orders.json";
        private List<Order> _orders = new();

        public OrderRepositoryJSON()
        {
            _orders = LoadFromFile();
        }
        public IEnumerable<Order> GetAll()
        {
            return _orders;
        }

        public void AddOrder(Order order) 
        {
            _orders.Add(order);
            SaveToFile();
        }

        public void RemoveOrder(Order order)
        {
            _orders.Remove(order);
            SaveToFile();
        }

        private List<Order> LoadFromFile()
        {
            if (!File.Exists(filePath)) return new List<Order>();

            try
            {
                string jsonString = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Order>>(jsonString) ?? new List<Order>();
            }
            catch
            {
                return new List<Order>();
            }
        }
        private void SaveToFile()
        {
            string jsonString = JsonSerializer.Serialize(_orders);
            File.WriteAllText(filePath, jsonString);
        }
    }
}
