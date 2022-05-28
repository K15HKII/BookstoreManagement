namespace BookstoreManagement.ViewModels;

public interface IViewModelFactory
{

    public TViewModel Create<TViewModel>() where TViewModel : BaseViewModel;

}