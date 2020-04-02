using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return producttoReturn;
        }
    }
}