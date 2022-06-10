using BookstoreManagement.ViewModels.DialogView.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Services;

namespace BookstoreManagement.ViewModels.Manager.EmployeeAdapter
{
    public class EmployeeInfoNavigator : IEmployeeInfoNavigator
    {
        private readonly IDialogService _dialogService;

        public EmployeeInfoNavigator(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }
        public object? OpenDetailEmployeeDialog(EmployeeDetailViewModel viewModel)
        {
            object? value = _dialogService.Show(viewModel);
            if (value == null)
                return null;
            return value;
        }
    }
}
