using System.Windows;
using System.Windows.Controls;
using GUI.ControlLayer;


namespace GUI
{
    /// <summary>
    /// Interaction logic for UpdateProductGUI.xaml
    /// </summary>
    public partial class UpdateProductGUI : Window
    {
        ProductControl _productControl;
        public UpdateProductGUI()
        {
            InitializeComponent();
            _productControl = new ProductControl();
            listProducts.ItemsSource = _productControl.GetAllProducts();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            

        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
