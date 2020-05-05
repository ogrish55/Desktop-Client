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
        public UpdateProductGUI()
        {
            pctr = new ProductControl();
            InitializeComponent();
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
            txtBrand.Text = p.Brand;
            txtCategory.Text = p.Category;
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            string Name;
            decimal Price;
            string Description;
            string Brand;
            string Category;

            try
            {
                Name = txtName.Text;
                Price = decimal.Parse(txtPrice.Text);
                Description = txtDescription.Text;
                Brand = txtBrand.Text;
                Category = txtCategory.Text;
 
                if (Name.Length > 0 && Description.Length > 0 && Price > 0 && Brand.Length > 0 && Category.Length > 0)
                {
                    Product updatedProduct = (Product)listProducts.SelectedItem;
                    updatedProduct.Name = Name;
                    updatedProduct.Price = Price;
                    updatedProduct.Description = Description;
                    updatedProduct.Brand = Brand;
                    updatedProduct.Category = Category;
                    
                    pctr.UpdateProduct(updatedProduct);
                    MessageBox.Show(updatedProduct.Name + " has been updated!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    listProducts.Items.Refresh();
                    
                }
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
