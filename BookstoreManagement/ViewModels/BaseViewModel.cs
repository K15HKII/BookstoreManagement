using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace BookstoreManagement.ViewModels;

public class BaseViewModel<N> : BaseViewModel where N : INavigator
{

    protected N Navigator { get; set; }

}

public class BaseViewModel : ObservableObject
{
    
}