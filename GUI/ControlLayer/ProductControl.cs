using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.ServiceLayer;

namespace GUI.ControlLayer
{
    public class ProductControl
    {

        public IEnumerable<GUI.ProductServiceReference.Product> GetAllProducts()
        {
            ProductService ps = new ProductService();
            
            return ps.GetAllProducts();
        }

    }
}
