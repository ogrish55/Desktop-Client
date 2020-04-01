using GUI.PresentationLayer;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddProduct addProductWindow = new AddProduct();
            addProductWindow.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window updateProductWindow = new UpdateProductGUI();
            updateProductWindow.Show();
            this.Hide();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            DeleteProductGUI deleteProductWindow = new DeleteProductGUI();
            deleteProductWindow.Show();
            this.Hide();
        }
    }
}