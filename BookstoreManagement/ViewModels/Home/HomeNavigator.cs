namespace BookstoreManagement.ViewModels.Home;

public interface HomeNavigator : INavigator
{
    void Logout();

    void openSetting();
}