using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.ServiceLayer;
using GUI.ProductServiceReference;
using GUI.ModelLayer;
using GUI.Utilities;

namespace GUI.ControlLayer
{
    public class ProductControl
    {
      
        public IEnumerable<Product> GetAllProducts()
        {
            ProductService ps = new ProductService();
            List<Product> listToReturn = new List<Product>();
            foreach (var item in ps.GetAllProducts())
            {
                listToReturn.Add(new ConvertDataModel().ConvertFromServiceProduct(item));
            }
            
            return listToReturn;
        }

        public void AddProduct(Product product)
        {
            new ProductService().InsertProduct(new ConvertDataModel().ConvertToServiceProduct(product));
        }

        public void DeleteProduct(int productId)
        {
            ProductService ps = new ProductService();

            ps.DeleteProduct(productId);
        }
    }
}
