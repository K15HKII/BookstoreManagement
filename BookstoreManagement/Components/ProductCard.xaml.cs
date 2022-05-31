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

namespace BookstoreManagement.Components
{
    /// <summary>
    /// Interaction logic for ProductCard.xaml
    /// </summary>
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();

            //BookProfileImage b = new BookProfileImage()
            //{
            //    Id = "1",
            //    Image = @"/BookstoreManagement;component/Images/image.jpg"
            //};

            //Image1.DataContext = b;
        }
    }
}
