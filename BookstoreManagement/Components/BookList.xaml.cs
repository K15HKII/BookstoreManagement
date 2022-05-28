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
    /// Interaction logic for BookList.xaml
    /// </summary>
    public partial class BookList : UserControl
    {
        public BookList()
        {
            InitializeComponent();

            BookProfile bookProfile = new BookProfile()
            {
                Id = "#1",
                Name = "ABC",
                Price = 10000,
                PublisherId = 1
            };

            BookProfile bookProfile1 = new BookProfile()
            {
                Id = "#2",
                Name = "ABC",
                Price = 10000,
                PublisherId = 1

            };

            //Publisher p = new Publisher()
            //{
            //    Id = 1,
            //    Name = "a"
            //};

            //BookProfileImage profileImage = new BookProfileImage()
            //{
            //    Id = "#1",
            //    Image = @"/BookstoreManagement;component/Images/image.jpg"
            //};

            itemsControl.ItemsSource = new List<BookProfile>() { bookProfile, bookProfile1 };
            
        }

    }
}
