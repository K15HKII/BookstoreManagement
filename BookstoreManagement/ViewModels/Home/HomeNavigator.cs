using BookstoreManagement.ViewModels.Login;
using BookstoreManagement.ViewModels.Setting;
using BookstoreManagement.Views.ViewStates;

namespace BookstoreManagement.ViewModels.Home;

public class HomeNavigator : IHomeNavigator
{

    private readonly IViewModelFactory _factory;
    private readonly MainViewState _mainViewState;

    public HomeNavigator(IViewModelFactory factory, MainViewState mainViewState)
    {
        _factory = factory;
        _mainViewState = mainViewState;
    }

    public void Logout()
    {
        _mainViewState.CurrentView = _factory.Create<LoginViewModel>();
    }

    public void openSetting()
    {
        _mainViewState.CurrentView = _factory.Create<SettingViewModel>();
    }
    
}