using GUI.ControlLayer;
using GUI.ModelLayer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;

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
            LabelError.Visibility = Visibility.Hidden;
        }

        private async Task UpdateListBoxOrders()
        {
            if (radioAll.IsChecked == true)
            {
                listOrders.ItemsSource = null;
                listOrders.Items.Clear();
                Task<IEnumerable<Order>> taskGetAll = _orderController.GetOrders(OrderController.EnumStatus.All);
                listOrders.ItemsSource = await taskGetAll;
            }

            else if (radioActive.IsChecked == true)
            {
                listOrders.ItemsSource = null;
                listOrders.Items.Clear();
                Task<IEnumerable<Order>> taskGetActive = _orderController.GetOrders(OrderController.EnumStatus.Active);
                listOrders.ItemsSource = await taskGetActive;
            }

            else if (radioCancel.IsChecked == true)
            {
                listOrders.ItemsSource = null;
                listOrders.Items.Clear();
                Task<IEnumerable<Order>> taskGetCancelled = _orderController.GetOrders(OrderController.EnumStatus.Cancelled);
                listOrders.ItemsSource = await taskGetCancelled;
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
            if (currentOrder != null)
            {
                currentOrder.Status = EnumOrderStatus.Cancelled;
                new OrderController().CancelOrder(currentOrder);
                UpdateListBoxOrders();
            }
            else
            {
                MessageBox.Show("Please select an order from the list");
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int idToSearchFor = Int32.Parse(TxtSearch.Text);
                LabelError.Visibility = Visibility.Hidden;
                Order orderToPresent = new OrderController().GetOrder(idToSearchFor);
                if (orderToPresent != null)
                {
                    listOrders.ItemsSource = null;
                    listOrders.Items.Add(orderToPresent);
                }
                else
                {
                    MessageBox.Show("No order matching the given ID");
                    UpdateListBoxOrders();
                }
            }
            catch (FormatException)
            {
                LabelError.Visibility = Visibility.Visible;
            }
        }

        private void RadioButton_Checked(object sender, EventArgs e)
        {
            UpdateListBoxOrders();
        }
    }
}
