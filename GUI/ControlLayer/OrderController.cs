using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.ModelLayer;
using GUI.ServiceLayer;
using GUI.Utilities;

namespace GUI.ControlLayer
{
    public class OrderController
    {
        public enum EnumStatus{
            All,
            Active,
            Cancelled
            };

        public IEnumerable<Order> GetOrders(EnumStatus status)
        {
            OrderService os = new OrderService();
            List<Order> listToReturn = new List<Order>();
            if(status == EnumStatus.All)
            {
                foreach (var item in os.GetAllOrders())
                {
                    listToReturn.Add(new ConvertDataModel().ConvertFromServiceOrder(item));
                }
            }

            if(status == EnumStatus.Cancelled)
            {
                foreach (var item in os.GetCancelledOrders())
                {
                    listToReturn.Add(new ConvertDataModel().ConvertFromServiceOrder(item));
                }
            }

            if(status == EnumStatus.Active)
            {
                foreach (var item in os.GetActiveOrders())
                {
                    listToReturn.Add(new ConvertDataModel().ConvertFromServiceOrder(item));
                }
            }

            return listToReturn;
        }

        public void CancelOrder(Order order)
        {
            new OrderService().UpdateOrder(new ConvertDataModel().ConvertToServiceOrder(order));
        }

        public Order GetOrder(int idToSearchFor)
        {
            return new ConvertDataModel().ConvertFromServiceOrder(new OrderService().GetOrder(idToSearchFor));
        }
    }
}
