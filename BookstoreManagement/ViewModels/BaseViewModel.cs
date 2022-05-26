using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace BookstoreManagement.ViewModels;

public abstract class BaseViewModel<N> : BaseViewModel where N : INavigator
{

    protected N Navigator { get; set; }

}

public abstract class BaseViewModel : ObservableObject
{
    
}