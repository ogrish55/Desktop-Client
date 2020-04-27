using GUI.ModelLayer;
using GUI.ProductLineServiceReferencee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.ServiceLayer
{
    public class ProductService
    {
        public IEnumerable<ServiceProduct> GetAllProducts()
        {
            IEnumerable<ServiceProduct> proxyProducts = null;

            using (ProductLineServiceClient productProxy = new ProductLineServiceClient())
            {
                proxyProducts = productProxy.GetAllProducts();
            }

            return proxyProducts;
        }

        public void InsertProduct(ServiceProduct product)
        {
            
            using(ProductLineServiceClient productProxy = new ProductLineServiceClient())
            {
                productProxy.InsertProduct(product);
            }
        }

        public void DeleteProduct(int productId)
        {
            using (ProductLineServiceClient productProxy = new ProductLineServiceClient())
            {
                productProxy.DeleteProduct(productId);
            }
        }

        public void UpdateProduct(ServiceProduct product)
        {
            using(ProductLineServiceClient productProxy = new ProductLineServiceClient())
            {
                Console.WriteLine(product.Name);
                Console.Read();
                productProxy.UpdateProduct(product);
            }
        }
    }
}
