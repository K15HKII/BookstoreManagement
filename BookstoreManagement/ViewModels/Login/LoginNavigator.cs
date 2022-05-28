using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Views.ViewStates;

namespace BookstoreManagement.ViewModels.Login
{
    public class LoginNavigator : ILoginNavigator
    {

        private readonly MainViewState _viewState;
        private readonly ViewModelCreator<HomeViewModel> _viewModelCreator;

        public LoginNavigator(MainViewState viewState, ViewModelCreator<HomeViewModel> viewModelCreator)
        {
            _viewState = viewState;
            _viewModelCreator = viewModelCreator;
        }

        public void openApp(object obj = null)
        {
            _viewState.CurrentView = _viewModelCreator.Invoke();
        }

    }
}
