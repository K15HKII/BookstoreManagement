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

namespace BookstoreManagement.Components
{
    /// <summary>
    /// Interaction logic for DashboardCustomerList.xaml
    /// </summary>
    public partial class DashboardCustomerList : UserControl
    {
        public DashboardCustomerList()
        {
            InitializeComponent();

            User user = new User()
            {
                FirstName = "a",
                LastName = "b",
                Email = "@gmail.com"
            };

            itemsControl.ItemsSource = new List<User>() { user, user, user };
        }
    }
}
