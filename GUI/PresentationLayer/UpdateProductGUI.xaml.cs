
using GUI.ControlLayer;
using GUI.ProductServiceReference;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


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
            this.pctr = new ProductControl();
            InitializeComponent();
            FillList();
        }

        private void FillList()
        {
            listProducts.Items.Clear();
            var allProducts = pctr.GetAllProducts();
            foreach (Product p in allProducts)
            {
                listProducts.Items.Add(p);
            }

        }
        private void Complain(Exception e)
        {
            MessageBox.Show("An error occured: " + e.Message);
        }

        private void listProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //When the Product model has been created, the calls below will be possible (.Name, .Description) etc.

            //txtName.Text = listProducts.SelectedItem.Name;
            //txtPrice.Text = listProducts.SelectedItem.Price;
            //txtDescription.Text = listProducts.SelectedItem.Description;

        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {

            string Name;
            string Price;
            string Description;
            try
            {
                Name = txtName.Text;
                Price = txtPrice.Text;
                Description = txtDescription.Text;
                double DoublePrice = double.Parse(Price);
                if (Name.Length > 0 && Description.Length > 0 && DoublePrice > 0)
                {   //Line below also requires Product model.
                    //int Id = listProducts.SelectedItem.Id;

                    //Here needs to be the call: pctr.Update(Id, Name, Price, Description)

                    
                }
            }
            catch (Exception ex)
            {
                Complain(ex);
            }

            
            




        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            listProducts.Items.Clear();
            
            
            
            
        }
    }
}
