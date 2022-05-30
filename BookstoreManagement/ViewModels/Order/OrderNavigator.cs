using BookstoreManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.ViewModels.DialogView.Order;

namespace BookstoreManagement.ViewModels.Order
{
    public class OrderNavigator : IOrderNavigator
    {

        private readonly IDialogService _dialogService;

        public OrderNavigator(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }

        public void openAccountScreen()
        {
            throw new NotImplementedException();
        }

        public void openNotificationScreen()
        {
            throw new NotImplementedException();
        }

        public BillAddRequest? OpenNewOrderDialog(AddOrderViewModel viewModel)
        {
            Task<object?> task = _dialogService.Show(viewModel);
            task.Wait();
            object? value = task.Result;
            if (value == null)
                return null;
            return value as BillAddRequest;
        }
    }
}
