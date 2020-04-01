using GUI.ProductServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.ServiceLayer
{
    public class ProductService
    {

        public IEnumerable<GUI.ProductServiceReference.Product> GetAllProducts()
        {
            IEnumerable<GUI.ProductServiceReference.Product> proxyProducts = null;

            using (ProductServiceClient productProxy = new ProductServiceClient())
            {
                proxyProducts = productProxy.GetAllProducts();
            }

            return proxyProducts;
        }

    }
}
