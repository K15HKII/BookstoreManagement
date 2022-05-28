using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace BookstoreManagement.ViewModels;

public delegate TViewModel ViewModelCreator<out TViewModel>() where TViewModel : BaseViewModel;

public class ViewModelFactory : IViewModelFactory
{

    private readonly App _app;
    
    public ViewModelFactory(Application app)
    {
        this._app = (App) app;
    }
    
    public TViewModel Create<TViewModel>() where TViewModel : BaseViewModel
    {
        return _app.ServiceProvider.GetRequiredService<ViewModelCreator<TViewModel>>().Invoke();
    }

}