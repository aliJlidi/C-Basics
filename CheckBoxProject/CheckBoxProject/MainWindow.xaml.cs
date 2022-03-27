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

namespace CheckBoxProject
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

        private void cbAllCheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllToping.IsChecked == true);
            cbSalami.IsChecked = newVal;
            cbMozzarila.IsChecked = newVal;
            cbMashrooms.IsChecked = newVal;
        }
        private void cbSingleCheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllToping.IsChecked = null;
            if ((cbSalami.IsChecked == true) && (cbMashrooms.IsChecked == true) && (cbMozzarila.IsChecked == true))
            {
                cbAllToping.IsChecked = true;
            }
            if ((cbSalami.IsChecked == false) && (cbMashrooms.IsChecked == false) && (cbMozzarila.IsChecked == false))
            {
                cbAllToping.IsChecked = false;
            }
        }
    }
}
