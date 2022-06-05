using System.Windows.Controls;

namespace BookstoreManagement.Components
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
