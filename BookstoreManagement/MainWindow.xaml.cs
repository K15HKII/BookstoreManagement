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
using BookstoreManagement.Data.Model.Api;

namespace BookstoreManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //itemsControl.ItemsSource = new List<Object> { a, b, a, a, a, a, a, a, a };
            //i.DataContext = a;

            //ii.DataContext = publisher;

            //iii.DataContext = voucher;

            //BookProfile bookProfile = new BookProfile()
            //{
            //    Id = "#1",
            //    Name = "ABC",
            //    Price = 10000,

            //};

            //BookProfile bookProfile1 = new BookProfile()
            //{
            //    Id = "#2",
            //    Name = "ABC",
            //    Price = 10000,

            //};

            //test.DataContext = new List<BookProfile>() { bookProfile };
        }
    }
}
