using System.Collections.Generic;
using System.Windows.Controls;
using BookstoreManagement.Data.Model.Api;

namespace BookstoreManagement.Components
{
    /// <summary>
    /// Interaction logic for CustomerList.xaml
    /// </summary>
    public partial class CustomerList : UserControl
    {

        public CustomerList()
        {
            InitializeComponent();

            User user = new User()
            {
                FirstName = "a",
                LastName = "b",
                Email = "@gmail.com"
            };

            itemsControl.ItemsSource = new List<User>() { user, user };
        }
    }
}
