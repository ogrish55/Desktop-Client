using GUI.ControlLayer;
using GUI.ProductServiceReference;
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
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            string Name;
            decimal Price;
            string Description;

            try
            {
                Name = txtName.Text;
                Price = decimal.Parse(txtPrice.Text);
                Description = txtDescription.Text;
 
                if (Name.Length > 0 && Description.Length > 0 && Price > 0)
                {
                    Product updatedProduct = (Product)listProducts.SelectedItem;
                    updatedProduct.Name = Name;
                    updatedProduct.Price = Price;
                    updatedProduct.Description = Description;
                    
                    pctr.UpdateProduct(updatedProduct);
                    MessageBox.Show(updatedProduct.Name + " has been updated!", "Success", MessageBoxButton.OK,MessageBoxImage.Information);
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
