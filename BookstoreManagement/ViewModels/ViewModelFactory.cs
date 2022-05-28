namespace BookstoreManagement.ViewModels;

public delegate TViewModel ViewModelCreator<out TViewModel>() where TViewModel : BaseViewModel;

public class ViewModelFactory
{
    
}