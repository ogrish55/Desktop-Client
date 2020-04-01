using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.ProductServiceReference;

namespace GUI.PresentationLayer
{
    class ProductService
    {
        public void InsertProduct(GUI.ProductServiceReference.Product product)
        {
            using(ProductServiceClient productProxy = new ProductServiceClient())
            {
                productProxy.InsertProduct(product);
            }
        }
    }
}
