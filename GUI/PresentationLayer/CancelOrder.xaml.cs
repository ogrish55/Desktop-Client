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
    /// Interaction logic for CancelOrder.xaml
    /// </summary>
    public partial class CancelOrder : Window
    {
        OrderController _orderController = new OrderController();

        public CancelOrder()
        {
            InitializeComponent();
            UpdateListBoxOrders();
        }

        private void UpdateListBoxOrders()
        {
            if(radioAll.IsChecked == true)
            {
                listOrders.ItemsSource =_orderController.GetOrders(OrderController.EnumStatus.All);
            }

            else if(radioActive.IsChecked == true)
            {
                listOrders.ItemsSource = _orderController.GetOrders(OrderController.EnumStatus.Active);
            }

            else if (radioCancel.IsChecked == true)
            {
                listOrders.ItemsSource = _orderController.GetOrders(OrderController.EnumStatus.Cancelled);
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Order currentOrder = (Order)listOrders.SelectedItem;
            if(currentOrder != null)
            {
                currentOrder.Status = EnumOrderStatus.Cancelled;
                new OrderController().CancelOrder(currentOrder);
            }
            else
            {
                MessageBox.Show("Please select an order from the list");
            }
        }
    }
}
