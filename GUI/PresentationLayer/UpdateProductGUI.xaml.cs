using GUI.ControlLayer;
using GUI.CustomerOrderServiceReference;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using GUI.ModelLayer;


namespace GUI
{
    /// <summary>
    /// Interaction logic for UpdateProductGUI.xaml
    /// </summary>
    public partial class UpdateProductGUI : Window
    {
        private ProductControl pctr;
        private List<Brand> brands;
        private List<Category> categories;
        public UpdateProductGUI()
        {
            InitializeComponent();

            pctr = new ProductControl();
            brands = (List<Brand>)pctr.GetAllBrands();
            categories = (List<Category>)pctr.GetAllCategories();
            BrandCombo.ItemsSource = brands;
            CategoryCombo.ItemsSource = categories;

            listProducts.ItemsSource = pctr.GetAllProducts();
        }

        private void Complain(Exception e, string message)
        {
            MessageBox.Show(message + "Error message: " + e.Message);
        }

        private void listProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Product p = (Product)listProducts.SelectedItem;
            txtName.Text = p.Name;
            txtPrice.Text = p.Price.ToString();
            txtDescription.Text = p.Description;
            BrandCombo.Text = GetBrandName(p.BrandId);
            CategoryCombo.Text = GetCategoryName(p.CategoryId);

        }

        private string GetBrandName(int id)
        {
            string brandName = "";
            foreach (var brand in brands)
            {
                if (id == brand.BrandId)
                {
                    brandName = brand.Name;
                }
            }
            return brandName;
        }

        private string GetCategoryName(int id)
        {
            string categoryName = "";
            foreach (var category in categories)
            {
                if (id == category.CategoryId)
                {
                    categoryName = category.Name;
                }
            }
            return categoryName;
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            string Name;
            decimal Price;
            string Description;
            int BrandId;
            int CategoryId;

            Brand selectedBrand = (Brand)BrandCombo.SelectedItem;
            Category selectedCategory = (Category)CategoryCombo.SelectedItem;

            try
            {
                Name = txtName.Text;
                Price = decimal.Parse(txtPrice.Text);
                Description = txtDescription.Text;
                BrandId = selectedBrand.BrandId;
                CategoryId = selectedCategory.CategoryId;

                if (Name.Length > 0 && Description.Length > 0 && Price > 0 && BrandId > 0 && CategoryId > 0)
                {
                    Product updatedProduct = (Product)listProducts.SelectedItem;
                    updatedProduct.Name = Name;
                    updatedProduct.Price = Price;
                    updatedProduct.Description = Description;
                    updatedProduct.BrandId = BrandId;
                    updatedProduct.CategoryId = CategoryId;

                    pctr.UpdateProduct(updatedProduct);
                    MessageBox.Show(updatedProduct.Name + " has been updated!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                listProducts.Items.Refresh();
            }
            catch (Exception ex)
            {
                Complain(ex, "Try again. ");
            }
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Search function

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}
