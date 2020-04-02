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

namespace GUI.PresentationLayer
{
    /// <summary>
    /// Interaction logic for DeleteProductGUI.xaml
    /// </summary>
    public partial class DeleteProductGUI : Window
    {
        private ProductControl _productControl;

        public DeleteProductGUI()
        {
            _productControl = new ProductControl();

            InitializeComponent();

            UpdateListBoxProducts();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            Product selectedProduct;
            selectedProduct = (Product)listBoxProducts.SelectedItem;
            if (selectedProduct != null)
            {
                _productControl.DeleteProduct(selectedProduct.ProductId);
                UpdateListBoxProducts();
            }
        }

        private void UpdateListBoxProducts()
        {
            var allProducts = _productControl.GetAllProducts();
            listBoxProducts.Items.Clear();
            foreach (Product product in allProducts)
            {
                listBoxProducts.Items.Add(product.ToString());
                // mangler at printe toString metoden i listen
            }
        }

    }
}
