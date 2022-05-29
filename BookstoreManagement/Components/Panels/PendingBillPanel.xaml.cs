using BookstoreManagement.Data.Model.Api;
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

namespace BookstoreManagement.Components.Panels
{
    /// <summary>
    /// Interaction logic for PendingBillPanel.xaml
    /// </summary>
    public partial class PendingBillPanel : UserControl
    {
        private Border[] tabMarks = new Border[3];

        public PendingBillPanel()
        {
            InitializeComponent();
            transitioner.SelectedIndex = 0;
            tabMarks[0] = confirmWaitingOrderSelectMark;
            tabMarks[1] = shippingOrderSelectMark;
            tabMarks[2] = shippedOrderSelectMark;
            selectTab(0);

            BillDetail billDetail = new BillDetail()
            {
                BillId = 0,
                Price = 1000
            };

            itemsControl.ItemsSource = new List<BillDetail>() { billDetail, billDetail, billDetail, billDetail, billDetail, billDetail, billDetail, billDetail, billDetail, billDetail, billDetail };
            itemsControl1.ItemsSource = new List<BillDetail>() { billDetail, billDetail, billDetail, billDetail, billDetail, billDetail };
        }

        private void selectTab(int index)
        {
            foreach (var mark in tabMarks) mark.Visibility = Visibility.Hidden;
            tabMarks[index].Visibility = Visibility.Visible;
        }

        private void btnMediaTab_Click(object sender, RoutedEventArgs e)
        {
            transitioner.SelectedIndex = 0;
            selectTab(0);
        }

        private void btnConfirmWaitingOrderTab_Click(object sender, RoutedEventArgs e)
        {
            transitioner.SelectedIndex = 0;
            selectTab(0);
        }

        private void btnShippingOrderTab_Click(object sender, RoutedEventArgs e)
        {
            transitioner.SelectedIndex = 1;
            selectTab(1);
        }

        private void btnShippedOrderTab_Click(object sender, RoutedEventArgs e)
        {
            transitioner.SelectedIndex = 2;
            selectTab(2);
        }
    }
}
