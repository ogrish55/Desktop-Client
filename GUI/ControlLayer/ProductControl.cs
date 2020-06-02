using System.Collections.Generic;
using GUI.ServiceLayer;
using GUI.ModelLayer;
using GUI.Utilities;

namespace GUI.ControlLayer
{
    public class ProductControl
    {
        readonly ConvertDataModel Converter = new ConvertDataModel();
        readonly ProductService ProductService = new ProductService();

        public IEnumerable<Product> GetAllProducts()
        {
            List<Product> listToReturn = new List<Product>();
            foreach (var item in ProductService.GetAllProducts())
            {
                listToReturn.Add(Converter.ConvertFromServiceProduct(item));
            }

            return listToReturn;
        }

        public void AddProduct(Product product)
        {
            ProductLineServiceReferencee.ServiceProduct serviceProduct;

            serviceProduct = Converter.ConvertToServiceProduct(product); // Convert the given product to a serviceProduct

            ProductService.InsertProduct(serviceProduct); // Insert the converted product
        }

        public void DeleteProduct(int productId)
        {
            ProductService.DeleteProduct(productId);
        }

        public void UpdateProduct(Product product)
        {
            ProductLineServiceReferencee.ServiceProduct serviceProduct;

            serviceProduct = Converter.ConvertToServiceProduct(product); // Convert the given product to a serviceProduct

            ProductService.UpdateProduct(serviceProduct); // Update the converted product
        }

        public IEnumerable<Category> GetAllCategories()
        {
            List<Category> listToReturn = new List<Category>();
            foreach (var item in ProductService.GetAllCategories())
            {
                listToReturn.Add(Converter.ConvertFromServiceCategory(item));
            }
            return listToReturn;
        }

        public IEnumerable<Brand> GetAllBrands()
        {
            List<Brand> listToReturn = new List<Brand>();
            foreach (var item in ProductService.GetAllBrands())
            {
                listToReturn.Add(Converter.ConvertFromServiceBrand(item));
            }
            return listToReturn;
        }
    }
}
