using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process2
{
    internal class OrderService
    {
        private readonly OrderRepository _orderRepo = new OrderRepository();

        public int CreateOrder(Order order)
        {
            return _orderRepo.InsertOrder(order);
        }

        public void AddOrderDetail(OrderDetail detail)
        {
            _orderRepo.InsertOrderDetail(detail);
        }

        public DataTable GetOrderReport()
        {
            return _orderRepo.GetOrderReport();
        }
        public DataTable GetAgents()
        {
            return _orderRepo.GetAgents();
        }

        public DataTable GetItemsByCustomerName(string customerName)
        {
            return _orderRepo.GetItemsByCustomerName(customerName);
        }

        public DataTable GetPurchasesByCustomerId(int customerId)
        {
            return _orderRepo.GetPurchasesByCustomerId(customerId);
        }
    }
}
