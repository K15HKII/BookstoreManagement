using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace BookstoreManagement.Views
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();

            List<String> items = new List<String>();
            items.Add("Complete this WPF tutorial");
            items.Add("Learn C#");
            items.Add("Wash the car");
            items.Add("Abc");
            items.Add("123");
            items.Add("456");
            items.Add("378");
            test.ItemsSource = items;
        }
    }
}
