using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.ServiceLayer;
using GUI.ProductServiceReference;

namespace GUI.ControlLayer
{
    public class ProductControl
    {

        public IEnumerable<GUI.ProductServiceReference.Product> GetAllProducts()
        {
            ProductService ps = new ProductService();
            
            return ps.GetAllProducts();
        }

        public void AddProduct(GUI.ProductServiceReference.Product product)
        {
            new ProductService().InsertProduct(product);
        }

    }
}
