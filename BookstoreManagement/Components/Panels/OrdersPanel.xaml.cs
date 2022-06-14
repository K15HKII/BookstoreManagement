using System.Windows.Controls;

namespace BookstoreManagement.Components
{
    /// <summary>
    /// Interaction logic for OrdersPanel.xaml
    /// </summary>
    public partial class OrdersPanel : UserControl
    {
        private Border[] tabMarks = new Border[3];

        public OrdersPanel()
        {
            InitializeComponent();
        }
    }
}
