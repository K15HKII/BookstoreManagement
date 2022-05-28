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
using System.Windows.Markup;
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
    ///     <MyNamespace:LoadingMask/>
    ///
    /// </summary>
    [ContentProperty("Content")]
    public class LoadingMask : Control
    {
        static LoadingMask()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LoadingMask), new FrameworkPropertyMetadata(typeof(LoadingMask)));
        }

        #region Content
        public static readonly DependencyProperty ContentProperty = DependencyProperty.Register(nameof(Content),
            typeof(object),
            typeof(LoadingMask),
            new FrameworkPropertyMetadata());

        public object Content
        {
            get => GetValue(ContentProperty);
            set => SetValue(ContentProperty, value);
        }
        #endregion

        #region Loading
        public static readonly DependencyProperty LoadingProperty = DependencyProperty.Register(nameof(Loading),
            typeof(bool),
            typeof(LoadingMask),
            new FrameworkPropertyMetadata(false));

        public bool Loading
        {
            get => (bool) GetValue(LoadingProperty);
            set => SetValue(LoadingProperty, value);
        }
        #endregion

    }
}
