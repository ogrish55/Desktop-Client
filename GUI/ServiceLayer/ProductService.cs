﻿using GUI.ProductServiceReference;
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

            using (ProductServiceClient productProxy = new ProductServiceClient())
            {
                proxyProducts = productProxy.GetAllProducts();
            }

            return proxyProducts;
        }

        public void InsertProduct(ServiceProduct product)
        {
            using(ProductServiceClient productProxy = new ProductServiceClient())
            {
                productProxy.InsertProduct(product);
            }
        }

    }
}
