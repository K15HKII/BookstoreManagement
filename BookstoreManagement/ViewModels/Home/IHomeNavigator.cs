namespace BookstoreManagement.ViewModels.Home;

public interface IHomeNavigator : INavigator
{
    void Logout();

    void OpenSetting();
}