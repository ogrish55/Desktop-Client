using System.Collections.Generic;
using System.Threading.Tasks;
using GUI.ModelLayer;
using GUI.ServiceLayer;
using GUI.Utilities;

namespace GUI.ControlLayer
{
    public class OrderController
    {
        readonly ConvertDataModel Converter = new ConvertDataModel();
        readonly OrderService OrderService = new OrderService();

        public enum EnumStatus{
            All,
            Active,
            Cancelled
            };

        public async Task<IEnumerable<Order>> GetOrders(EnumStatus status)
        {
            await Task.Delay(1000);
            List<Order> listToReturn = new List<Order>();

            if(status == EnumStatus.All) // If Enum status is All, retrieve all orders using the OrderService.
            {
                foreach (var item in OrderService.GetAllOrders())
                {
                    listToReturn.Add(Converter.ConvertFromServiceOrder(item));
                }
            }

            if(status == EnumStatus.Cancelled) // If Enum status is Cancelled, retrieve all cancelled orders using the OrderService.
            {
                foreach (var item in OrderService.GetCancelledOrders())
                {
                    listToReturn.Add(Converter.ConvertFromServiceOrder(item));
                }
            }

            if(status == EnumStatus.Active) // If Enum status is Active, retrieve all active orders using the OrderService.
            {
                foreach (var item in OrderService.GetActiveOrders())
                {
                    listToReturn.Add(Converter.ConvertFromServiceOrder(item));
                }
            }

            return listToReturn;
        }

        public void CancelOrder(Order order)
        {
            CustomerOrderServiceReference.ServiceCustomerOrder ServiceOrder;

            ServiceOrder = Converter.ConvertToServiceOrder(order); // Convert Order to ServiceCustomerOrder

            OrderService.UpdateOrder(ServiceOrder); // Update the converted ServiceCustomerOrder

        }

        public Order GetOrder(int idToSearchFor)
        {
            CustomerOrderServiceReference.ServiceCustomerOrder ServiceOrder = OrderService.GetOrder(idToSearchFor); // Get ServiceCustomerOrder object using OrderService

            Order orderToReturn = Converter.ConvertFromServiceOrder(ServiceOrder); // Convert retrieved ServiceCustomerOrder to Order using Converter

            return orderToReturn; // Return converted Order
        }
    }
}