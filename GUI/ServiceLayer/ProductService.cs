using GUI.ProductServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.ProductServiceReference;

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

        public void InsertProduct(GUI.ProductServiceReference.Product product)
        {
            
            using(ProductServiceClient productProxy = new ProductServiceClient())
            {
                productProxy.InsertProduct(product);
            }
        }
    }
}
