using System.Windows;
using System.Windows.Controls;
using BookstoreManagement.ViewModels.BookStore;

namespace BookstoreManagement.Utils;

public class ViewSelector : DataTemplateSelector
{
    
    public override DataTemplate
        SelectTemplate(object item, DependencyObject container)
    {
        FrameworkElement element = container as FrameworkElement;

        if (element != null && item != null && item is BookPanelViewModel)
        {
            BookPanelViewModel vm = item as BookPanelViewModel;

            if (vm.DataGridView)
                return
                    element.FindResource("DataGridView") as DataTemplate;
            else
                return
                    element.FindResource("DefaultView") as DataTemplate;
        }

        return null;
    }
    
}