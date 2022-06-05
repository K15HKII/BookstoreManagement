using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.ViewModels.DialogView;

namespace BookstoreManagement.ViewModels.Lend
{
    public interface ILendNavigator : INavigator
    {
        void openAccountScreen();

        void openNotificationScreen();
        
        Task<LendUpdateRequest?> OpenNewLendBillDialog(AddLendBillViewModel viewModel);
    }
}
