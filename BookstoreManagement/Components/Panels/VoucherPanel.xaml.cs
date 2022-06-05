using System;
using System.Collections.Generic;
using System.Windows.Controls;
using BookstoreManagement.Data.Model.Api;

namespace BookstoreManagement.Components
{
    /// <summary>
    /// Interaction logic for VoucherPanel.xaml
    /// </summary>
    public partial class VoucherPanel : UserControl
    {
        public VoucherPanel()
        {
            InitializeComponent();

            Voucher v = new Voucher()
            {
                ExpiredDate = DateTime.Now,
            };

            itemsControl.ItemsSource = new List<Voucher>() { v, v, v, v, v, v, v, v, v, v };
        }
    }
}
