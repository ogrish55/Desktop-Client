using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.PresentationLayer;
using GUI.ProductServiceReference;

namespace GUI.ControlLayer
{
    class ProductControl
    {
        public void AddProduct(GUI.ProductServiceReference.Product product)
        {
            new ProductService().InsertProduct(product);
        }
    }
}
