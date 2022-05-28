using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Views.ViewStates;

namespace BookstoreManagement.ViewModels.Setting
{
    public class SettingNavigator : ISettingNavigator
    {

        private readonly MainViewState _viewState;

        public SettingNavigator(MainViewState viewState)
        {
            _viewState = viewState;
        }

        public void Backward()
        {
            _viewState.Backward();
        }
    }
}
