﻿using System;
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
        public CancelOrder()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Hide();
        }
    }
}
