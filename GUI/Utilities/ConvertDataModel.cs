﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.CustomerOrderServiceReference;
using GUI.ModelLayer;
using GUI.ProductServiceReference;

namespace GUI.Utilities
{
    public class ConvertDataModel : IConvertModel
    {
        public ModelLayer.Product ConvertFromServiceProduct(ServiceProduct serviceProduct)
        {
            GUI.ModelLayer.Product productToReturn = new ModelLayer.Product();
            productToReturn.Name = serviceProduct.Name;
            productToReturn.Price = serviceProduct.Price;
            productToReturn.Description = serviceProduct.Description;
            productToReturn.ProductId = serviceProduct.ProductId;

            return productToReturn;
        }

        public ServiceProduct ConvertToServiceProduct(ModelLayer.Product desktopProduct)
        {
            ServiceProduct producttoReturn = new ServiceProduct();
            producttoReturn.Description = desktopProduct.Description;
            producttoReturn.Name = desktopProduct.Name;
            producttoReturn.Price = desktopProduct.Price;
            producttoReturn.ProductId = desktopProduct.ProductId;
            return producttoReturn;
        }

        public Order ConvertFromServiceOrder(ServiceCustomerOrder item)
        {
            Order orderToReturn = new Order();
            orderToReturn.Date = item.DateOrder;
            orderToReturn.Status = (EnumOrderStatus)Enum.Parse(typeof(EnumOrderStatus), item.Status);
            return orderToReturn;
        }

        internal ServiceCustomerOrder ConvertToServiceOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}