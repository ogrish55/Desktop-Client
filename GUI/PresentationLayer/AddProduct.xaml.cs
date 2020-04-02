using GUI.ControlLayer;
using GUI.ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GUI
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {

        ProductControl productControl;
        public AddProduct()
        {
            InitializeComponent();
            productControl = new ProductControl();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (CheckForInput())
            {
                Product product = new Product
                {
                    Name = NameTxt.Text,
                    Price = Convert.ToDecimal(PriceTxt.Text),
                    Description = DescriptionTxt.Text
                };
                productControl.AddProduct(product);
                MessageBox.Show(product.Name + " Successfully added to database");

            }
            else
            {
                MessageBox.Show("Please fill out all the text fields");
            }
        }

        private bool CheckForInput()
        {
            bool success = false;
            if(NameTxt.Text.Length > 0 && PriceTxt.Text.Length > 0 && DescriptionTxt.Text.Length > 0)
            {
                success = true;
            }
            return success;
        }
    }
}
