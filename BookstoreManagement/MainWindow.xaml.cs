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


            BookProfile a = new BookProfile()
            {
                Name = "ABC",
                AuthorId = 10,
                Price = 10000,
                Description = "Aluha"
            };
            BookProfile b = new BookProfile()
            {
                Name = "ABCASDA",
                AuthorId = 10,
                Price = 10000,
                Description = "Aluha"
            };
            List<Object> list = new List<Object>
            {
                a,
                b,
                a,
                a,
                b,
                b,
                new CartItem()
                {
                    BookProfile = "jawdlawd"
                }
            };
            itemsControl.ItemsSource = list;
        }
    }
}
