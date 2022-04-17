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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : UserControl
    {

        #region Property FloatingContent

        /// <summary>
        /// Floating Content (ex: Button) on navigation rail (optional)
        /// </summary>
        public static readonly DependencyProperty FloatingContentProperty = DependencyProperty.Register(
            "FloatingContent", typeof(object), typeof(MainMenu), new PropertyMetadata(null));

        public static object GetFloatingContent(DependencyObject element) => (object) element.GetValue(FloatingContentProperty);
        public static void SetFloatingContent(DependencyObject element, object value) => element.SetValue(FloatingContentProperty, value);

        public object FloatingContent
        {
            get => GetFloatingContent(this);
            set => SetFloatingContent(this, value);
        }

        #endregion

        public MainMenu()
        {
            InitializeComponent();
        }
    }
}
