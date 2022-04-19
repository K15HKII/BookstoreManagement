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
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:BookstoreManagement.Components"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:BookstoreManagement.Components;assembly=BookstoreManagement.Components"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:NumberNavigationBar/>
    ///
    /// </summary>
    public class NumberNavigationBar : Control
    {
        static NumberNavigationBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NumberNavigationBar),
                new FrameworkPropertyMetadata(typeof(NumberNavigationBar)));
        }

        public static readonly DependencyProperty SpacingProperty = DependencyProperty.Register("Spacing",
            typeof(Thickness), typeof(NumberNavigationBar),
            new UIPropertyMetadata(new Thickness()));

        public Thickness Spacing
        {
            get => (Thickness) this.GetValue(SpacingProperty);
            set => this.SetValue(SpacingProperty, value);
        }

        public static readonly DependencyProperty PagesProperty = DependencyProperty.Register("Pages", typeof(int),
            typeof(NumberNavigationBar),
            new UIPropertyMetadata(0));

        public int Pages { get => (int) this.GetValue(PagesProperty); set => this.SetValue(PagesProperty, value); }

        public static readonly DependencyProperty NumberTemplateProperty = DependencyProperty.Register("NumberTemplate",
            typeof(ContentControl),
            typeof(NumberNavigationBar),
            new FrameworkPropertyMetadata());

        public ContentControl NumberTemplate { get => (ContentControl) this.GetValue(NumberTemplateProperty); set => this.SetValue(NumberTemplateProperty, value); }

        public static readonly DependencyProperty LeftTemplateProperty = DependencyProperty.Register("LeftTemplate",
            typeof(ContentControl),
            typeof(NumberNavigationBar),
            new FrameworkPropertyMetadata());

        public ContentControl LeftTemplate { get => (ContentControl) this.GetValue(LeftTemplateProperty); set => this.SetValue(LeftTemplateProperty, value); }

        public static readonly DependencyProperty RightTemplateProperty = DependencyProperty.Register("RightTemplate",
            typeof(ContentControl),
            typeof(NumberNavigationBar),
            new FrameworkPropertyMetadata());

        public ContentControl RightTemplate { get => (ContentControl) this.GetValue(RightTemplateProperty); set => this.SetValue(RightTemplateProperty, value); }

        public static readonly DependencyProperty LeftContentProperty = DependencyProperty.Register("LeftContent",
            typeof(object),
            typeof(NumberNavigationBar),
            new FrameworkPropertyMetadata());

        public object LeftContent { get => this.GetValue(LeftContentProperty); set => this.SetValue(LeftContentProperty, value); }

        public static readonly DependencyProperty RightContentProperty = DependencyProperty.Register("RightContent",
            typeof(object),
            typeof(NumberNavigationBar),
            new FrameworkPropertyMetadata());

        public object RightContent { get => this.GetValue(RightContentProperty); set => this.SetValue(RightContentProperty, value); }

        private static void OnNumberTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((NumberNavigationBar) d).OnNumberTemplateChanged((DataTemplate) e.OldValue, (DataTemplate) e.NewValue);
        }

        protected virtual void OnNumberTemplateChanged(DataTemplate oldItemTemplate, DataTemplate newItemTemplate)
        {
        }

        private Panel _itemHost;

        public NumberNavigationBar()
        {
            Initialize();
        }

        private void Initialize()
        {
            //_itemHost = (Panel) this.FindName("PART_Container");
            ItemsControl a;
            a.ItemsPanel
        }
    }

    public class NumberNavigationButton : Button
    {

        public static readonly DependencyProperty NumberTemplateProperty = DependencyProperty.Register("NumberTemplate",
            typeof(ContentControl),
            typeof(NumberNavigationBar),
            new FrameworkPropertyMetadata());

        public NumberNavigationButton()
        {

        }

    }
}