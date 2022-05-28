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
using MaterialDesignThemes.Wpf;

namespace BookstoreManagement.Components
{
    /// <summary>
    /// Interaction logic for MainMenuItem.xaml
    /// </summary>
    public partial class MainMenuItem : UserControl
    {
        
        #region Icon
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(nameof(Icon),
            typeof(PackIconKind),
            typeof(MainMenuItem),
            new FrameworkPropertyMetadata());

        public PackIconKind Icon
        {
            get => (PackIconKind) GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }
        #endregion
        
        #region Text
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof(Text),
            typeof(string),
            typeof(MainMenuItem),
            new FrameworkPropertyMetadata());

        public string Text
        {
            get => (string) GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
        #endregion
        
        public MainMenuItem()
        {
            InitializeComponent();
        }
        
    }
}
