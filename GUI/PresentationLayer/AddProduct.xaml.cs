using GUI.ControlLayer;
using GUI.ModelLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            BrandCombo.ItemsSource = productControl.GetAllBrands();
            CategoryCombo.ItemsSource = productControl.GetAllCategories();

            Product product = new Product()
            {
                Name = null,
                Price = 0.0m,
                Description = null,
                AmountOnStock = 0
            };

            Brand brand = new Brand()
            {
                Name = null
            };

            Category category = new Category()
            {
                Name = null
            };

            this.DataContext = new
            {
                Product = product,
                Brand = brand,
                Category = category
            };

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Brand selectedBrand = (Brand)BrandCombo.SelectedItem;
            Category selectedCategory = (Category)CategoryCombo.SelectedItem;
            if (CheckForInput())
            {
                Product product = new Product
                {
                    Name = NameTxt.Text,
                    Price = Convert.ToDecimal(PriceTxt.Text),
                    Description = DescriptionTxt.Text,
                    AmountOnStock = Convert.ToInt32(AmountOnStockTxt.Text),
                    BrandId = selectedBrand.BrandId,
                    CategoryId = selectedCategory.CategoryId
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
            if (NameTxt.Text.Length > 0 && PriceTxt.Text.Length > 0 && DescriptionTxt.Text.Length > 0 && AmountOnStockTxt.Text.Length > 0 && CategoryCombo.SelectedItem != null
                && BrandCombo.SelectedItem != null)
            {
                success = true;
                try
                {
                    Decimal.Parse(PriceTxt.Text);
                    Int32.Parse(AmountOnStockTxt.Text);
                }
                catch (FormatException)
                {
                    success = false;
                }
            }
            return success;
        }


    }
}
