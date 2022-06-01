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
        }
    }
}
