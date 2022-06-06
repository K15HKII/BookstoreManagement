using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.ViewModels.DialogView.Order;

namespace BookstoreManagement.ViewModels.Order
{
    public interface IOrderNavigator : INavigator
    {
        void openAccountScreen();

        void openNotificationScreen();
        
        Task<BillUpdateRequest?> OpenNewOrderDialog(AddOrderViewModel viewModel);
    }
}
