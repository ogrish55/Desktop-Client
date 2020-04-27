using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.CustomerOrderServiceReference;
using GUI.ModelLayer;

namespace GUI.Utilities
{
    public class ConvertDataModel : IConvertModel
    {
        public Product ConvertFromServiceProduct(ProductLineServiceReferencee.ServiceProduct serviceProduct)
        {
            Product productToReturn = new Product();
            productToReturn.Name = serviceProduct.Name;
            productToReturn.Price = serviceProduct.Price;
            productToReturn.Description = serviceProduct.Description;
            productToReturn.ProductId = serviceProduct.ProductId;
            productToReturn.Brand = serviceProduct.Brand;

            return productToReturn;
        }

        public ProductLineServiceReferencee.ServiceProduct ConvertToServiceProduct(Product desktopProduct)
        {
            ProductLineServiceReferencee.ServiceProduct producttoReturn = new ProductLineServiceReferencee.ServiceProduct();
            producttoReturn.Description = desktopProduct.Description;
            producttoReturn.Name = desktopProduct.Name;
            producttoReturn.Price = desktopProduct.Price;
            producttoReturn.ProductId = desktopProduct.ProductId;
            producttoReturn.AmountOnStock = desktopProduct.AmountOnStock;
            producttoReturn.Brand = desktopProduct.Brand;
            return producttoReturn;
        }

        public Order ConvertFromServiceOrder(ServiceCustomerOrder item)
        {
            Order orderToReturn = null;
            if(item != null)
            {
                orderToReturn = new Order();
                orderToReturn.Date = item.DateOrder;
                orderToReturn.OrderId = item.OrderId;
                if (item.Status != null)
                {
                    orderToReturn.Status = (EnumOrderStatus)Enum.Parse(typeof(EnumOrderStatus), item.Status);
                }

            }
            return orderToReturn;
        }

        public ServiceCustomerOrder ConvertToServiceOrder(Order order)
        {
            ServiceCustomerOrder orderToReturn = new ServiceCustomerOrder();
            orderToReturn.OrderId = order.OrderId;
            orderToReturn.Status = order.Status.ToString();
            return orderToReturn;
        }

    }
}