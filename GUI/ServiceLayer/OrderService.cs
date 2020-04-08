using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.CustomerOrderServiceReference;

namespace GUI.ServiceLayer
{
    public class OrderService
    {
        public void UpdateOrder(ServiceCustomerOrder order)
        {
            using(CustomerOrderServiceClient orderProxy = new CustomerOrderServiceClient())
            {
                orderProxy.UpdateOrder(order);
            }
        }

        public IEnumerable<ServiceCustomerOrder> GetAllOrders()
        {
            using(CustomerOrderServiceClient orderProxy = new CustomerOrderServiceClient())
            {
                return orderProxy.GetAllOrders();
            }
        }
        public IEnumerable<ServiceCustomerOrder> GetCancelledOrders()
        {
            using (CustomerOrderServiceClient orderProxy = new CustomerOrderServiceClient())
            {
                return orderProxy.GetCancelledOrders();
            }
        }

        public IEnumerable<ServiceCustomerOrder> GetActiveOrders()
        {
            using (CustomerOrderServiceClient orderProxy = new CustomerOrderServiceClient())
            {
                return orderProxy.GetActiveOrders();
            }
        }
    }
}
