using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.ViewModels.DialogView.Manager;

namespace BookstoreManagement.ViewModels.Manager
{
    public interface IManagerNavigator : INavigator
    {
        void openAccountScreen();

        void openNotificationScreen();
        
        Task<UserUpdateRequest?> OpenNewEmployeeDialog(UpdateEmployeeViewModel viewModel);
    }
}
